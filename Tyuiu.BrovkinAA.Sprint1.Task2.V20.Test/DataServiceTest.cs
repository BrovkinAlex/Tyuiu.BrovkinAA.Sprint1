using Tyuiu.BrovkinAA.Sprint1.Task2.V20.Lib;
namespace Tyuiu.BrovkinAA.Sprint1.Task2.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSquaresSumm()
        {
            DataService ds = new DataService();
            int x = 5, y = 2;

            Assert.AreEqual(29, ds.CalculateSquaresSumm(x, y));
        }
    }
}