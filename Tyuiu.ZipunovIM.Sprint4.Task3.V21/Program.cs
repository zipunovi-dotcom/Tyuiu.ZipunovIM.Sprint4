using System;
using Tyuiu.ZipunovIM.Sprint4.Task3.V21;

namespace Tyuiu.ZipunovIM.Sprint4.Task3.V21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Зипунов И. М.";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы (статический ввод)                              *");
            Console.WriteLine("* Задание #4.3                                                            *");
            Console.WriteLine("* Вариант #21                                                             *");
            Console.WriteLine("* Выполнил: Зипунов И. М.                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* статическими значениями в диапазоне от 3 до 8. Найдите произведение     *");
            Console.WriteLine("* элементов в последнем столбце массива.                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[,] matrix = new int[5, 5]
            {
                { 8, 3, 3, 3, 5 },
                { 6, 7, 3, 3, 7 },
                { 4, 5, 4, 6, 6 },
                { 5, 5, 8, 8, 7 },
                { 4, 6, 6, 7, 7 }
            };

            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            Console.WriteLine("Массив:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{matrix[i, j]} \t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int result = ds.Calculate(matrix);

            Console.WriteLine("Произведение элементов в последнем столбце = " + result);
            Console.ReadKey();
        }
    }
}