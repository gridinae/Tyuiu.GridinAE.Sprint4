using Tyuiu.GridinAE.Sprint4.Task3.V23.Lib;

namespace Tyuiu.GridinAE.Sprint4.Task3.V23.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void TestCalculate()
    {
        Assert.AreEqual(2, new DataService().Calculate(new int[,] { { 10, 3, 7 }, { 5, 5, 4 } }));
    }
}