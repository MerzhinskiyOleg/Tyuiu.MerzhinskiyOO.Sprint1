using Tyuiu.MerzhinskiyOO.Sprint1.Task3.V15.Lib;

namespace Tyuiu.MerzhinskiyOO.Sprint1.Task3.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            DataService ds = new DataService();
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("Введите скорость первого автомобиля V1: ");
            double v1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите скорость второго автомобиля V2 : ");
            double v2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите расстояние между автомобилями S : ");
            double S = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите время T: ");
            double T = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("Расстояние между автомобилями через T часов: " + ds.DistanceOverTime(v1, v2, S, T));
            Console.ReadKey();
        }
    }
}
