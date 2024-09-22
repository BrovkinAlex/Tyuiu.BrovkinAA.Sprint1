using Tyuiu.BrovkinAA.Sprint1.Task3.V10.Lib;
namespace Tyuiu.BrovkinAA.Sprint1.Task3.V10.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void ValidExpression()
    {
        DataService ds = new DataService();
        double num = 23.6019;
        double res = 23.602;
        Assert.AreEqual(res, ds.NumberToMoney(num));
}
}