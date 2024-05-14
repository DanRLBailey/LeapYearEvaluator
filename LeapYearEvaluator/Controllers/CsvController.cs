using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYearEvaluator.Controllers
{
    public class CsvController
    {
        public void OutputToCsv(List<bool> list, string columnHeaders = "", string path = "")
        {
            string filepath = $"{path}output.csv";
            string csvData = CreateCsvData(list, columnHeaders);

            File.WriteAllText(filepath, csvData.ToString());
        }

        public string CreateCsvData(List<bool> list, string columnHeaders = "Col1,Col2")
        {
            StringBuilder csv = new StringBuilder();
            csv.AppendLine(columnHeaders);

            for (int i = 0; i < list.Count; i++)
            {
                string output = list[i] ? "Yes" : "No";
                csv.AppendLine($"{i + 1},{output}");
            }

            return csv.ToString();
        }
    }
}
