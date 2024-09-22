using Tyuiu.BrovkinAA.Sprint1.Task5.V1.Lib;
namespace Tyuiu.BrovkinAA.Sprint1.Task5.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double Ax = -4, Ay = -1;
            double Bx = 8, By = 7;

            int res = ds.DistanceBetweenDots(Ax, Ay, Bx, By);

            Assert.AreEqual(14, res);
        }
    }
}