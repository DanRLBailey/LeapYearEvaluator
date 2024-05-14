using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public List<bool> GetLeapYears()
        {
            List<bool> result = new List<bool>();
            int currentYear = DateTime.Now.Year;

            for (int i = 1; i <= currentYear; i++)
                result.Add(IsLeapYear(i));

            return result;
        }
    }
}
