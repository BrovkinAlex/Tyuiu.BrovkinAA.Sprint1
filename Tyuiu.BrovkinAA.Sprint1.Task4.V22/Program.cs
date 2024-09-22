using Tyuiu.BrovkinAA.Sprint1.Task1.V22.Lib;
namespace Tyuiu.BrovkinAA.Sprint1.Task1.V22
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
            Console.WriteLine("* Задание #4                                                                  *");
            Console.WriteLine("* Вариант #22                                                                 *");
            Console.WriteLine("* Выполнил Бровкин Алексей Александрович | ИБКСб-24-1                         *");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("* УСЛОВИЕ:                                                                    *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,     *");
            Console.WriteLine("* вычисляет результат по формуле и печатает его на экране.                    *");
            Console.WriteLine("* Ответ округлить до 3 знаков после запятой.                                  *");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                            *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("* ФОРМУЛА              √(x * y)                                               *");
            Console.WriteLine("*                  ----------------                                           *");
            Console.WriteLine("*                   1 + (x + 2y)^2                                            *");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("*******************************************************************************");

            double x;
            Console.Write("\nВведите значение х: ");
            x = Convert.ToDouble(Console.ReadLine());

            double y;
            Console.Write("Введите значение y: ");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n*******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                  *");
            Console.WriteLine("*******************************************************************************\n");

            Console.WriteLine(ds.Calculate(x, y));
            Console.ReadKey();
        }
    }
}
