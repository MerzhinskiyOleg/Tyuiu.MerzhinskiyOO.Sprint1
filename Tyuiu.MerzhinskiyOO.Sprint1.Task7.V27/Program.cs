using Tyuiu.MerzhinskiyOO.Sprint1.Task7.V27.Lib;

namespace Tyuiu.MerzhinskiyOO.Sprint1.Task7.V27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            DataService ds = new DataService();
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("    CosX^2 + SinY^2       XY - 12");
            Console.WriteLine("Z = ---------------  -  -----------");
            Console.WriteLine("        SinY + 1         15 + CosX");


            double x, y;
            Console.WriteLine("Введите X: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите Y: ");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("    CosX^2 + SinY^2       XY - 12");
            Console.WriteLine($"Z = ---------------  -  -----------  = {ds.Calculate(x, y)}");
            Console.WriteLine("        SinY + 1         15 + CosX");
            Console.ReadKey();
        }
    }
}
