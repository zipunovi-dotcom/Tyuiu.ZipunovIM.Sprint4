using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.ZipunovIM.Sprint4.Task3.V21
{
    public class DataService : ISprint4Task3V21
    {
        public int Calculate(int[,] matrix)
        {
            int product = 1;
            int rows = matrix.GetLength(0);
            int lastColumnIndex = matrix.GetLength(1) - 1; // Последний столбец

            for (int i = 0; i < rows; i++)
            {
                product *= matrix[i, lastColumnIndex];
            }

            return product;
        }
    }
}