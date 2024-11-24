namespace Tyuiu.GridinAE.Sprint4.Task2.V6.Lib;

using tyuiu.cources.programming.interfaces.Sprint4;

public class DataService : ISprint4Task2V6
{
    public int Calculate(int[] array)
    {
        int mult = 1;
        foreach (int i in array.Where(x => x % 2 == 1))
            mult *= i;
        return mult;
    }
}
