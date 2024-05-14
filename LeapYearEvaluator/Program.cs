using LeapYearEvaluator.Controllers;

namespace LeapYearEvaluator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LeapYearController leapYearController = new LeapYearController();
            List<bool> leapYears = leapYearController.GetLeapYears();

            Console.WriteLine($"Total Leap Years: {leapYears.Count(y => y)}");

            CsvController csvController = new CsvController();
            csvController.OutputToCsv(leapYears, "Year,LeapYear");
        }
    }
}
