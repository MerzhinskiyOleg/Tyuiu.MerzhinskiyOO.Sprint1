using Tyuiu.MerzhinskiyOO.Sprint1.Task4.V3.Lib;

namespace Tyuiu.MerzhinskiyOO.Sprint1.Task4.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            DataService ds = new DataService();
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            DataService dataService = new DataService();
            double result = Math.Round(dataService.Calculate(x, y), 3);
            Console.WriteLine("Результат вычисления выражения: " + result);
            Console.ReadLine();
        }
    }
}
