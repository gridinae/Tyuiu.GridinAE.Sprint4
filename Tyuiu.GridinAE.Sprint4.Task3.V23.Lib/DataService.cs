namespace Tyuiu.GridinAE.Sprint4.Task3.V23.Lib;

using tyuiu.cources.programming.interfaces.Sprint4;

public class DataService : ISprint4Task3V23
{
    public int Calculate(int[,] array) => array.Cast<int>().Where(x => x % 2 == 0).Count();
}
