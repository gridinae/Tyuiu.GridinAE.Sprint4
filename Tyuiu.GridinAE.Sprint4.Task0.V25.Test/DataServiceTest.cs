namespace Tyuiu.GridinAE.Sprint4.Task0.V25.Test;

using Tyuiu.GridinAE.Sprint4.Task0.V25.Lib;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void TestGetSumEvenArrEl()
    {
        DataService dataService = new();

        Assert.AreEqual(18, dataService.GetSumEvenArrEl([2, 4, 3, 2, 2, 8, 9]));
    }
}