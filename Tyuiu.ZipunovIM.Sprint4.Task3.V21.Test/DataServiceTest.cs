using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ZipunovIM.Sprint4.Task3.V21;

namespace Tyuiu.ZipunovIM.Sprint4.Task3.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] matrix = new int[5, 5]
            {
                { 8, 3, 3, 3, 5 },
                { 6, 7, 3, 3, 7 },
                { 4, 5, 4, 6, 6 },
                { 5, 5, 8, 8, 7 },
                { 4, 6, 6, 7, 7 }
            };

            int expected = 10290; // 5 * 7 * 6 * 7 * 7

            int actual = ds.Calculate(matrix);

            Assert.AreEqual(expected, actual);
        }
    }
}