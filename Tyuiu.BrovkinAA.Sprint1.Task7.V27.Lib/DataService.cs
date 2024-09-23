using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.BrovkinAA.Sprint1.Task7.V27.Lib
{
    public class DataService : ISprint1Task7V27
    {
        public double Calculate(double x, double y)
        {
            double firstRes = (Math.Cos(Math.Pow(x, 2)) + Math.Sin(Math.Pow(y, 2))) / (Math.Sin(y) + 1);
            double secondRes = (x * y - 12) / (15 + Math.Cos(x));
            return Math.Round(firstRes - secondRes, 3);
            
        }
    }
}
