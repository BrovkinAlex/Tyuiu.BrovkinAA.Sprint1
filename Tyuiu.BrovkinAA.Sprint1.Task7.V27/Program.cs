using Tyuiu.BrovkinAA.Sprint1.Task7.V27.Lib;
namespace Tyuiu.BrovkinAA.Sprint1.Task7.V27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт 1 | Выполнит Бровкин А. А. | ИБКСб-24-1";

            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("* Спринт #1                                                                   *");
            Console.WriteLine("* Тема: Создания итогового решения по спринту                                 *");
            Console.WriteLine("* Задание #7                                                                  *");
            Console.WriteLine("* Вариант #27                                                                 *");
            Console.WriteLine("* Выполнил Бровкин Алексей Александрович | ИБКСб-24-1                         *");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("* УСЛОВИЕ:                                                                    *");
            Console.WriteLine("* Написать программу, которая вычисляет математическое выражение              *");
            Console.WriteLine("* по исходным значениям данных, вводимых пользователем.                       *");
            Console.WriteLine("* Ответ округлите до 3 знаков после запятой.                                  *");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                            *");
            Console.WriteLine("*******************************************************************************\n");

            Console.WriteLine("     (cos(x^2) + sin(x^2)        xy - 12");
            Console.WriteLine("z = ----------------------  —  –—-----------");
            Console.WriteLine("         sin(y) + 1             15 + cos(x)");

            Console.Write("\nВведите значение Х: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите значение У: ");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n*******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                  *");
            Console.WriteLine("*******************************************************************************\n");

            Console.WriteLine("Значение функции Z = " + ds.Calculate(x, y));
            Console.ReadKey();
        }
    }
}
