namespace Tyuiu.GridinAE.Sprint4.Task4.V4.Test;

using Tyuiu.GridinAE.Sprint4.Task4.V4.Lib;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void TestCalculate()
    {
        CollectionAssert.AreEqual(new int[,] { { 1, 1 }, { 1, 7 } }, new DataService().Calculate(new int[,] { { 2, 4 }, { 8, 7 } }));
    }
}