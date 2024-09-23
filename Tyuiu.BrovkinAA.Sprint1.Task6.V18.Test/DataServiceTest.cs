using Tyuiu.BrovkinAA.Sprint1.Task6.V18.Lib;
namespace Tyuiu.BrovkinAA.Sprint1.Task6.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            string numTest1 = "529";
            string numTest2 = "2az";

            Assert.AreEqual(true, ds.CheckNumber(numTest1));
            Assert.AreEqual(false, ds.CheckNumber(numTest2));
        }
    }
}