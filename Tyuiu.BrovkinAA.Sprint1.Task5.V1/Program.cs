using Tyuiu.BrovkinAA.Sprint1.Task5.V1.Lib;
namespace Tyuiu.BrovkinAA.Sprint1.Task5.V1
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
            Console.WriteLine("* Задание #5                                                                  *");
            Console.WriteLine("* Вариант #1                                                                  *");
            Console.WriteLine("* Выполнил Бровкин Алексей Александрович | ИБКСб-24-1                         *");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("* УСЛОВИЕ:                                                                    *");
            Console.WriteLine("* Написать программу, которая находит расстояние между                        *");
            Console.WriteLine("* двумя точками с заданными координатами (x, y).                              *");
            Console.WriteLine("* Ответ привести к целому с помощью класса Convert.                           *");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                            *");
            Console.WriteLine("*******************************************************************************");

            double Ax = -4, Ay = -1;
            double Bx = 8, By = 7;

            Console.WriteLine($"\nКоординаты точки А: ({Ax}, {Ay})");
            Console.WriteLine($"Координаты точки B: ({Bx}, {By})");

            Console.WriteLine("\n*******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                  *");
            Console.WriteLine("*******************************************************************************\n");

            Console.WriteLine($"Растояние между точками = {ds.DistanceBetweenDots(Ax, Ay, Bx, By)}");
            Console.ReadKey();
        }
    }
}
