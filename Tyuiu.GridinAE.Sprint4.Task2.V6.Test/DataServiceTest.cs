namespace Tyuiu.GridinAE.Sprint4.Task2.V6.Test;

using Tyuiu.GridinAE.Sprint4.Task2.V6.Lib;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void TestCalculate()
    {
        Assert.AreEqual(35, new DataService().Calculate([2, 4, 6, 8, 5, 7, 1, 0]));
    }
}