using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.ZipunovIM.Sprint4.Task0.V2
{
    public class DataService : ISprint4Task0V2
    {
        public int GetSumOddArrEl(int[] array)
        {
            int sum = 0;
            foreach (int item in array)
            {
                // Проверяем элемент на нечетность
                if (item % 2 != 0)
                {
                    sum += item;
                }
            }
            return sum;
        }
    }
}