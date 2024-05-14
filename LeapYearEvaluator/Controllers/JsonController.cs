using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LeapYearEvaluator.Models;

namespace LeapYearEvaluator.Controllers
{
    public class BoolToYesNoConverter : JsonConverter<bool>
    {
        public override bool Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => reader.GetString() == "Yes" ? true : false;
        public override void Write(Utf8JsonWriter writer, bool value, JsonSerializerOptions options) => writer.WriteStringValue(value ? "Yes" : "No");
    }

    public class JsonController
    {
        public void OutputYearListToJson(List<YearModel> list, string path = "")
        {
            string filepath = $"{path}output.json";
            File.WriteAllText(filepath, JsonSerializer.Serialize(
                list,
                new JsonSerializerOptions
                {
                    WriteIndented = true,
                    Converters = { new BoolToYesNoConverter() }
                }
            ));
        }
    }
}
