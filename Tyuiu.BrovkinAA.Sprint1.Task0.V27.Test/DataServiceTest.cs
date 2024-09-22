namespace Tyuiu.BrovkinAA.Sprint1.Task0.V27.Test;
using Tyuiu.BrovkinAA.Sprint1.Task0.V27.Lib;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void ValidExpession()
    {
        var ds = new DataService();
        Assert.AreEqual(22, ds.Calculate());
    }
}