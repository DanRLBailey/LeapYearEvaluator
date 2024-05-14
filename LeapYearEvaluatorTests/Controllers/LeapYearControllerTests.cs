using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeapYearEvaluator.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYearEvaluator.Controllers.Tests
{
    [TestClass()]
    public class LeapYearControllerTests
    {
        [TestMethod()]
        public void LeapYearReturnsTrueTest()
        {
            int year = 4;
            bool expected = true;

            LeapYearController leapYearController = new LeapYearController();
            bool actual = leapYearController.IsLeapYear(year);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void DivisibleBy400IsLeapYearTest()
        {
            int year = 400;
            bool expected = true;

            LeapYearController leapYearController = new LeapYearController();
            bool actual = leapYearController.IsLeapYear(year);

            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod()]
        public void DivisibleBy100IsNotLeapYearTest()
        {
            int year = 100;
            bool expected = false;

            LeapYearController leapYearController = new LeapYearController();
            bool actual = leapYearController.IsLeapYear(year);

            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod()]
        public void DivisibleBy200IsNotLeapYearTest()
        {
            int year = 200;
            bool expected = false;

            LeapYearController leapYearController = new LeapYearController();
            bool actual = leapYearController.IsLeapYear(year);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void TotalLeapYearsIsCorrectTest()
        {
            int expected = 491; //Total leap years since the year 1

            LeapYearController leapYearController = new LeapYearController();
            List<bool> result = leapYearController.GetLeapYears();
            int actual = result.Count(y => y);

            Assert.AreEqual(expected, actual);
        }
    }
}