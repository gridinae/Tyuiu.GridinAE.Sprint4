namespace Tyuiu.GridinAE.Sprint.Task0.V25.Lib;

using tyuiu.cources.programming.interfaces.Sprint4;

public class DataService : ISprint4Task0V25
{
    public int GetSumEvenArrEl(int[] array) => array.Where(x => x % 2 == 0).Sum();
}
