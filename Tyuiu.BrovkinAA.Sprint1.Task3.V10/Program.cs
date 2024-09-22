using Tyuiu.BrovkinAA.Sprint1.Task3.V10.Lib;
namespace Tyuiu.BrovkinAA.Sprint1.Task3.V10
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
            Console.WriteLine("* Задание #3                                                                  *");
            Console.WriteLine("* Вариант #10                                                                 *");
            Console.WriteLine("* Выполнил Бровкин Алексей Александрович | ИБКСб-24-1                         *");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("* УСЛОВИЕ:                                                                    *");
            Console.WriteLine("* Написать программу, которая преобразует введенное с клавиатуры              *");
            Console.WriteLine("* дробное число в денежный формат и печатает результат на экране.             *");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                            *");
            Console.WriteLine("*******************************************************************************");

            double x;
            Console.WriteLine("\nВведите число: ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n*******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                  *");
            Console.WriteLine("*******************************************************************************\n");

            Console.WriteLine(ds.NumberToMoney(x));
            Console.ReadKey();
        }
    }
}
