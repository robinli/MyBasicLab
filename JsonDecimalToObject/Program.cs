using JsonDecimalToObject.Model;
using JsonDecimalToObject.Service;

namespace JsonDecimalToObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Install-Package Newtonsoft.Json -Version 13.0.1");

            MonkeyService service = new MonkeyService();

            var monkeys = service.GetMonkeys();

            Console.WriteLine(monkeys.Count);
            
            foreach(Monkey monkey in monkeys)
            {
                Console.WriteLine(monkey.Name);
                Console.WriteLine(monkey.Latitude);
                Console.WriteLine(monkey.Longitude);
                Console.WriteLine("*****");
            }

            Console.ReadLine();

        }
    }
}