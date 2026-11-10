
using Tyuiu.ZipunovIM.Sprint4.Task1.V3;
namespace Tyuiu.KornevRM.Sprint4.Task1.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] array = { 4, 8, 8, 9, 6, 5, 3, 2, 9, 7, 7, 7 };
            int res = ds.Calculate(array);
            int wait = 96;
            Assert.AreEqual(wait, res);
        }
    }
}