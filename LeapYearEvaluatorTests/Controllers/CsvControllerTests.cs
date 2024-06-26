﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeapYearEvaluator.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestPlatform.Utilities;
using LeapYearEvaluator.Models;

namespace LeapYearEvaluator.Controllers.Tests
{
    [TestClass()]
    public class CsvControllerTests
    {
        [TestMethod()]
        public void TrueLeapYearOutputsYesTest()
        {
            List<YearModel> outputs = new List<YearModel>()
            {
                new YearModel{ Year = 1, LeapYear = true }
            };

            StringBuilder csv = new StringBuilder();
            csv.AppendLine("Col1,Col2");
            csv.AppendLine("1,Yes");

            string expected = csv.ToString();

            CsvController csvController = new CsvController();
            string actual = csvController.CreateCsvDataFromYearList(outputs);

            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod()]
        public void FalseLeapYearOutputsNoTest()
        {
            List<YearModel> outputs = new List<YearModel>()
            {
                new YearModel{ Year = 1, LeapYear = false }
            };

            StringBuilder csv = new StringBuilder();
            csv.AppendLine("Col1,Col2");
            csv.AppendLine("1,No");

            string expected = csv.ToString();

            CsvController csvController = new CsvController();
            string actual = csvController.CreateCsvDataFromYearList(outputs);

            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod()]
        public void LeapYearListGeneratesMultilineCsvTest()
        {
            List<YearModel> outputs = new List<YearModel>()
            {
                new YearModel{ Year = 1, LeapYear = true },
                new YearModel{ Year = 2, LeapYear = true },
                new YearModel{ Year = 3, LeapYear = false },
                new YearModel{ Year = 4, LeapYear = true }
            };

            StringBuilder csv = new StringBuilder();
            csv.AppendLine("Col1,Col2");
            csv.AppendLine("1,Yes");
            csv.AppendLine("2,Yes");
            csv.AppendLine("3,No");
            csv.AppendLine("4,Yes");

            string expected = csv.ToString();

            CsvController csvController = new CsvController();
            string actual = csvController.CreateCsvDataFromYearList(outputs);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CsvOutputWithPathGetsWrittenToCorrectPathTest()
        {
            List<YearModel> outputs = new List<YearModel>()
            {
                new YearModel{ Year = 1, LeapYear = false }
            };
            string filePath = $"{AppDomain.CurrentDomain.BaseDirectory}";

            CsvController csvController = new CsvController();
            csvController.OutputYearListToCsv(outputs, "", filePath);

            bool actual = File.Exists($"{filePath}output.csv");
            Assert.AreEqual(true, actual);
        }
        
        [TestMethod()]
        public void CsvOutputWithoutPathGetsWrittenToCorrectPathTest()
        {
            List<YearModel> outputs = new List<YearModel>()
            {
                new YearModel{ Year = 1, LeapYear = false }
            };

            CsvController csvController = new CsvController();
            csvController.OutputYearListToCsv(outputs);

            bool actual = File.Exists("output.csv");
            Assert.AreEqual(true, actual);
        }
    }
}