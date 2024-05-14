using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeapYearEvaluator.Models;

namespace LeapYearEvaluator.Controllers
{
    public class LeapYearController
    {
        public bool IsLeapYear(int year)
        {
            if (year % 4 == 0)
            {
                if (year % 400 == 0) return true;
                else if (year % 100 == 0) return false;

                return true;
            }

            return false;
        }

        public List<YearModel> GetLeapYears()
        {
            List<YearModel> result = new List<YearModel>();
            int currentYear = DateTime.Now.Year;

            for (int i = 1; i <= currentYear; i++)
                result.Add(new YearModel
                {
                    Year = i,
                    LeapYear = IsLeapYear(i),
                });

            return result;
        }
    }
}
