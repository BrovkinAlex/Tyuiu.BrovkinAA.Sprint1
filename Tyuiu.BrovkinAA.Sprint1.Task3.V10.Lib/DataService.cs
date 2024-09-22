using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.BrovkinAA.Sprint1.Task3.V10.Lib
{
    public class DataService : ISprint1Task3V10
    {
        public double NumberToMoney(double number)
        {
            return Math.Round(number, 3);
        }
    }
}
