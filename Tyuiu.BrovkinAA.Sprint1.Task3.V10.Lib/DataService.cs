using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.BrovkinAA.Sprint1.Task3.V10.Lib
{
    public class DataService : ISprint1Task3V10
    {
        public double NumberToMoney(double number)
        {
            if (Math.Round(number % Math.Floor(number), 2) != 1) 
                return Math.Round(number % Math.Floor(number), 2) * 100;

            return 0;
        }
    }
}
