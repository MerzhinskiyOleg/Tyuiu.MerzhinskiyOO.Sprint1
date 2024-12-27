using Tyuiu.MerzhinskiyOO.Sprint1.Task1.V25.Lib;
namespace Tyuiu.MerzhinskiyOO.Sprint1.Task1.V25.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double y = 2.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(1, res);
        }

    }
}