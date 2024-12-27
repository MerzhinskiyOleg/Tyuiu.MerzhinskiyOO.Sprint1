using Tyuiu.MerzhinskiyOO.Sprint1.Task0.V10.Lib;
namespace Tyuiu.MerzhinskiyOO.Sprint1.Task0.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Class1 ds = new Class1();
            Console.WriteLine("* УСЛОВИЕ:                                                                *"); 
            Console.WriteLine("* Написать программу, которая вычисляет выражение (3/6-4)*3 и             *");
            Console.WriteLine("* печатает результат на экране.                                           *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* (3/6-4)*3                                                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬАТ:                                                               *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.Calculate());
            Console.ReadLine();
        }
    }
}
