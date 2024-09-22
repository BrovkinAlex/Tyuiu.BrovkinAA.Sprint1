using Tyuiu.BrovkinAA.Sprint1.Task1.V9.Lib;
namespace Tyuiu.BrovkinAA.Sprint1.Task1.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт 1 | Выполнит Бровкин А. А. | ИБКСб-24-1";

            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* Спринт #1                                                                   *");
            Console.WriteLine("* Тема: Создания итогового решения по спринту                                 *");
            Console.WriteLine("* Задание #1                                                                  *");
            Console.WriteLine("* Вариант #9                                                                  *");
            Console.WriteLine("* Выполнил Бровкин Алексей Александрович | ИБКСб-24-1                         *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                    *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,     *");
            Console.WriteLine("* вычисляет результат по формуле (1+3*x)/(4*y) и печатает его на экране.      *");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                            *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* (1+3*x)/(4*y)                                                               *");
            Console.WriteLine("*******************************************************************************");

            double x;
            Console.WriteLine("\nВведите Х:");
            x = Convert.ToDouble(Console.ReadLine());

            double y;
            Console.WriteLine("Введите Y:");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n*******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                  *");
            Console.WriteLine("*******************************************************************************\n");

            Console.WriteLine(ds.Calculate(x, y));
            Console.ReadKey();
        }
    }
}
