using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ZipunovIM.Sprint4.Task7.V28.Lib;

namespace Tyuiu.ZipunovIM.Sprint4.Task7.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            int rows = 5;
            int columns = 3;
            int[,] mtrx = new int[rows, columns];
            string str = "623351179845632";

            DataService ds = new DataService();
            int res = ds.Calculate(rows, columns, str);
            int wait = 4608;

            Assert.AreEqual(wait, res);
        }
    }
}