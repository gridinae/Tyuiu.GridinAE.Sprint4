namespace Tyuiu.GridinAE.Sprint4.Task7.V29.Lib;

using tyuiu.cources.programming.interfaces.Sprint4;

public class DataService : ISprint4Task7V29
{
    public int Calculate(int n, int m, string value)
    {
        int[,] matrix = new int[n, m];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                matrix[i, j] = Convert.ToInt32(value.ElementAt(i * m + j).ToString());
            }
        }
        return matrix.Cast<int>().Where(x => x % 2 == 0).Sum();
    }
}
