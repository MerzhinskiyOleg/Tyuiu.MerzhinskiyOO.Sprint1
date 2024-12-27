using Tyuiu.MerzhinskiyOO.Sprint1.Task5.V1.Lib;

namespace Tyuiu.MerzhinskiyOO.Sprint1.Task5.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            DataService ds = new DataService();
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                           *");
            Console.WriteLine("**************************************************************************************************************");

            double x1;
            Console.WriteLine("Введите координату первой точки на оси Ох:");
            x1 = Convert.ToDouble(Console.ReadLine());

            double y1;
            Console.WriteLine("Введите координату первой точки на оси Оу:");
            y1 = Convert.ToDouble(Console.ReadLine());

            double x2;
            Console.WriteLine("Введите координату второй точки на оси Ох:");
            x2 = Convert.ToDouble(Console.ReadLine());

            double y2;
            Console.WriteLine("Введите координату второй точки на оси Оу:");
            y2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                 *");
            Console.WriteLine("**************************************************************************************************************");

            Console.WriteLine(ds.DistanceBetweenDots(x1, y1, x2, y2));
            Console.ReadKey();
        }
    }
}
