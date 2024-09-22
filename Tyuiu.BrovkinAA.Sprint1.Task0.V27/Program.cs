using Tyuiu.BrovkinAA.Sprint1.Task0.V27.Lib;
namespace Tyuiu.BrovkinAA.Sprint1.Task0.V27;


internal class Program
{
    // Написать программу, которая вычисляет выражение 5*2 + 4*3 и печатает результат на экране.
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт 1 | Выполнит Бровкин А. А. | ИБКСб-24-1";

        Console.WriteLine("*******************************************************************************");
        Console.WriteLine("* Спринт #1                                                                   *");
        Console.WriteLine("* Тема: Создания итогового решения по спринту                                 *");
        Console.WriteLine("* Задание #0                                                                  *");
        Console.WriteLine("* Вариант #27                                                                  *");
        Console.WriteLine("* Выполнил Бровкин Алексей Александрович | ИБКСб-24-1                         *");
        Console.WriteLine("*******************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                    *");
        Console.WriteLine("* Написать программу, которая вычисляет выражение 5*2 + 4*3                   *");
        Console.WriteLine("*                                                                             *");
        Console.WriteLine("*******************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                            *");
        Console.WriteLine("*******************************************************************************");
        Console.WriteLine("* 5*2 + 4*3                                                                   *");
        Console.WriteLine("*******************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                                  *");
        Console.WriteLine("*******************************************************************************");

        Console.WriteLine(ds.Calculate());

        Console.ReadKey();
    }
}
