namespace Tyuiu.GridinAE.Sprint4.Task6.V30.Test;
using Tyuiu.GridinAE.Sprint4.Task6.V30.Lib;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void TestCalculate()
    {
        CollectionAssert.AreEqual
        (
            new string[] { "Ананас", "Баклажан", "Смородина" },
            new DataService().Calculate(["Дыня", "Вишня", "Ананас", "Арбуз", "Баклажан", "Смородина"])
        );
    }
}