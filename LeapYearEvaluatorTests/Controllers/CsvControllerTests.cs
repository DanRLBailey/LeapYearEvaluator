using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeapYearEvaluator.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestPlatform.Utilities;

namespace LeapYearEvaluator.Controllers.Tests
{
    [TestClass()]
    public class CsvControllerTests
    {
        [TestMethod()]
        public void CsvDataCreatesProperlyTest()
        {
            List<bool> outputs = new List<bool>()
            {
                true, true, false, true
            };

            StringBuilder csv = new StringBuilder();
            csv.AppendLine("Col1,Col2");
            csv.AppendLine("1,Yes");
            csv.AppendLine("2,Yes");
            csv.AppendLine("3,No");
            csv.AppendLine("4,Yes");

            string expected = csv.ToString();

            CsvController csvController = new CsvController();
            string actual = csvController.CreateCsvData(outputs);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void FileGetsWrittenToCorrectPathTest()
        {
            List<bool> outputs = new List<bool>()
            {
                true, true, false, true
            };
            string filePath = @$"{AppDomain.CurrentDomain.BaseDirectory}";

            CsvController csvController = new CsvController();
            csvController.OutputToCsv(outputs, "", filePath);

            bool actual = File.Exists(@$"{filePath}output.csv");
            Assert.AreEqual(true, actual);
        }
    }
}