using Tyuiu.BrovkinAA.Sprint1.Task3.V10.Lib;
namespace Tyuiu.BrovkinAA.Sprint1.Task3.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double num = 23.6019;
            double res = 60;
            Assert.AreEqual(res, ds.NumberToMoney(num));

            Assert.AreEqual(0, ds.NumberToMoney(15));
            Assert.AreEqual(0, ds.NumberToMoney(71.99999));
            Assert.AreEqual(99, ds.NumberToMoney(1.99));
        }
    }
}