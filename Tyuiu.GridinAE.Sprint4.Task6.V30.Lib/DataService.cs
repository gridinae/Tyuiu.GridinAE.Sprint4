namespace Tyuiu.GridinAE.Sprint4.Task6.V30.Lib;
using tyuiu.cources.programming.interfaces.Sprint4;

public class DataService : ISprint4Task6V30
{
    public string[] Calculate(string[] array) => array.Where(x => x.Length > 5).ToArray();
}
