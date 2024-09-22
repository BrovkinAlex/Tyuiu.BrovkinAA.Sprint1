using Tyuiu.BrovkinAA.Sprint1.Task1.V22.Lib;
namespace Tyuiu.BrovkinAA.Sprint1.Task1.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2, y = 2;
            double res = 0.054;

            Assert.AreEqual(res, ds.Calculate(x, y));
        }
    }
}