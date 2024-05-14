using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeapYearEvaluator.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeapYearEvaluator.Models;

namespace LeapYearEvaluator.Controllers.Tests
{
    [TestClass()]
    public class JsonControllerTests
    {
        [TestMethod()]
        public void JsonOutputWithPathGetsWrittenToCorrectPathTest()
        {
            List<YearModel> outputs = new List<YearModel>()
            {
                new YearModel{ Year = 1, LeapYear = false },
                new YearModel{ Year = 2, LeapYear = false },
                new YearModel{ Year = 3, LeapYear = false },
                new YearModel{ Year = 4, LeapYear = true }
            };
            string filePath = @$"{AppDomain.CurrentDomain.BaseDirectory}";

            JsonController jsonController = new JsonController();
            jsonController.OutputYearListToJson(outputs, filePath);

            bool actual = File.Exists(@$"{filePath}output.json");
            Assert.AreEqual(true, actual);
        }
        
        [TestMethod()]
        public void JsonOutputWithoutPathGetsWrittenToCorrectPathTest()
        {
            List<YearModel> outputs = new List<YearModel>()
            {
                new YearModel{ Year = 1, LeapYear = false },
                new YearModel{ Year = 2, LeapYear = false },
                new YearModel{ Year = 3, LeapYear = false },
                new YearModel{ Year = 4, LeapYear = true }
            };

            JsonController jsonController = new JsonController();
            jsonController.OutputYearListToJson(outputs);

            bool actual = File.Exists("output.json");
            Assert.AreEqual(true, actual);
        }
    }
}