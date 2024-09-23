using Tyuiu.BrovkinAA.Sprint1.Task7.V27.Lib;
namespace Tyuiu.BrovkinAA.Sprint1.Task7.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1; double y = 3;
            double wait = 1.414;
            double res = ds.Calculate(x, y);

            Assert.AreEqual(wait, res);
            Assert.AreEqual(-37.077, ds.Calculate(51, 12));
        }
    }
}