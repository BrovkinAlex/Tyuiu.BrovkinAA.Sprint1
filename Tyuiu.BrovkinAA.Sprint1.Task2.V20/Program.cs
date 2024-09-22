using Tyuiu.BrovkinAA.Sprint1.Task2.V20.Lib;
namespace Tyuiu.BrovkinAA.Sprint1.Task2.V20
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
            Console.WriteLine("* Задание #2                                                                  *");
            Console.WriteLine("* Вариант #20                                                                 *");
            Console.WriteLine("* Выполнил Бровкин Алексей Александрович | ИБКСб-24-1                         *");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("* УСЛОВИЕ:                                                                    *");
            Console.WriteLine("* Заданы два числа. Вычислить сумму их квадратов.                             *");
            Console.WriteLine("* Пользователь вводит первое число (целое), второе число (целое)              *");
            Console.WriteLine("* Программа печатает на экране Сумму квадратов (целое число)                  *");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                            *");
            Console.WriteLine("*******************************************************************************");

            int x;
            Console.WriteLine("\nВведите первое число:");
            x = Convert.ToInt32(Console.ReadLine());

            int y;
            Console.WriteLine("Введите второе число:");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n*******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                  *");
            Console.WriteLine("*******************************************************************************\n");

            Console.WriteLine(ds.CalculateSquaresSumm(x, y));
            Console.ReadKey();
        }
    }
}
