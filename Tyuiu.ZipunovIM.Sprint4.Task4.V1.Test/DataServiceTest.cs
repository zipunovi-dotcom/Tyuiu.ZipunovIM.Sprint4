using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ZipunovIM.Sprint4.Task4.V1.Lib;

namespace Tyuiu.ZipunovIM.Sprint4.Task4.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] mas2 = new int[,]
            {
                { 2, 5, 1, 7, 5 },
                { 4, 4, 7, 4, 4 },
                { 7, 1, 6, 8, 8 },
                { 8, 1, 5, 8, 4 },
                { 8, 9, 1, 7, 3 }
            };

            int res = ds.Calculate(mas2);
            int wait = 68;

            Assert.AreEqual(wait, res);
        }
    }
}