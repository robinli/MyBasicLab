using JsonDecimalToObject.Model;
using JsonDecimalToObject.Service;

namespace JsonDecimalToObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

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