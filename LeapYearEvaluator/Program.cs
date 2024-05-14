using LeapYearEvaluator.Controllers;
using LeapYearEvaluator.Models;

namespace LeapYearEvaluator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LeapYearController leapYearController = new LeapYearController();
            List<YearModel> leapYears = leapYearController.GetLeapYears();

            Console.WriteLine($"Total Leap Years: {leapYears.Count(y => y.LeapYear)}");

            CsvController csvController = new CsvController();
            csvController.OutputYearListToCsv(leapYears, "Year,LeapYear");
        }
    }
}
