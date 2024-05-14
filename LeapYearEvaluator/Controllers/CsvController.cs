using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeapYearEvaluator.Models;

namespace LeapYearEvaluator.Controllers
{
    public class CsvController
    {
        public void OutputYearListToCsv(List<YearModel> list, string columnHeaders = "", string path = "")
        {
            string filepath = $"{path}output.csv";
            string csvData = CreateCsvDataFromYearList(list, columnHeaders);

            File.WriteAllText(filepath, csvData.ToString());
        }

        public string CreateCsvDataFromYearList(List<YearModel> list, string columnHeaders = "Col1,Col2")
        {
            StringBuilder csv = new StringBuilder();
            csv.AppendLine(columnHeaders);

            foreach (YearModel year in list)
            {
                string output = year.LeapYear ? "Yes" : "No";
                csv.AppendLine($"{year.Year},{output}");
            }

            return csv.ToString();
        }
    }
}
