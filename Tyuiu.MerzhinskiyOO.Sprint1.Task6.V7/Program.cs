using Tyuiu.MerzhinskiyOO.Sprint1.Task6.V7.Lib;

namespace Tyuiu.MerzhinskiyOO.Sprint1.Task6.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("***************************************************************************");

            string h;

            Console.WriteLine("Введите текст:");
            h = Console.ReadLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.DeleteLastLetter(h));
            Console.ReadKey();
        }
    }
}
