using JsonDecimalToObject.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonDecimalToObject.Service
{
    public class MonkeyService
    {
        public List<Monkey> GetMonkeys()
        {
            List<Monkey> monkeys = new List<Monkey>();
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "RawData", "monkeydata_NullDecimal.json");
                string json = System.IO.File.ReadAllText(path);
                monkeys = System.Text.Json.JsonSerializer.Deserialize<List<Monkey>>(json);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }

            return monkeys;
        }
    }
}
