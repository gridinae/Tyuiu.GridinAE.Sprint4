namespace Tyuiu.GridinAE.Sprint4.Task5.V22.Test;

using Tyuiu.GridinAE.Sprint4.Task5.V22.Lib;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void TestCalculate()
    {
        Assert.AreEqual(2, new DataService().Calculate(new int[,] { { -1, 0 }, { 2, -4 } }));
    }
}