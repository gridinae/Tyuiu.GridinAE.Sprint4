namespace Tyuiu.GridinAE.Sprint4.Task7.V29.Test;

using Tyuiu.GridinAE.Sprint4.Task7.V29.Lib;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void TestCalculate()
    {
        Assert.AreEqual(12, new DataService().Calculate(4, 2, "01234567"));
    }
}