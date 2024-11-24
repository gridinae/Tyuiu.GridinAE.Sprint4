namespace Tyuiu.GridinAE.Sprint4.Task5.V22.Lib;

using tyuiu.cources.programming.interfaces.Sprint4;

public class DataService : ISprint4Task5V22
{
    public int Calculate(int[,] matrix) => matrix.Cast<int>().Where(x => x < 0).Count();
}
