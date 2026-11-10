using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ZipunovIM.Sprint4.Task0.V2;

namespace Tyuiu.ZipunovIM.Sprint4.Task0.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumOddArrEl()
        {
            // Arrange
            DataService ds = new DataService();
            int[] array = { 5, 3, 7, 1, 3, 9, 8, 7, 9, 4 };
            int expected = 44; // 5 + 3 + 7 + 1 + 3 + 9 + 7 + 9 = 44

            // Act
            int actual = ds.GetSumOddArrEl(array);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}