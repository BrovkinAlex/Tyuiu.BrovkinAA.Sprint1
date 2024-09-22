using Tyuiu.BrovkinAA.Sprint1.Task1.V9.Lib;
namespace Tyuiu.BrovkinAA.Sprint1.Task1.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 1;

            Assert.AreEqual(1.75, ds.Calculate(x, y));
        }
    }
}