using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ZipunovIM.Sprint4.Task5.V19.Lib;

namespace Tyuiu.ZipunovIM.Sprint4.Task5.V19.Test
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
                { -2,  3,  0,  1, -1 },
                {  2, -2,  3,  0,  1 },
                { -1,  2, -2,  3,  0 },
                {  1, -1,  2, -2,  3 },
                {  0,  1, -1,  2,  3 }
            };

            int res = ds.Calculate(mas2);
            int wait = 13;

            Assert.AreEqual(wait, res);
        }
    }
}