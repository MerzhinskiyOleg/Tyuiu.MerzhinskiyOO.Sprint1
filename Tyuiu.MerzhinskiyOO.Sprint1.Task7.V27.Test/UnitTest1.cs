using Tyuiu.MerzhinskiyOO.Sprint1.Task7.V27.Lib;

namespace Tyuiu.MerzhinskiyOO.Sprint1.Task7.V27.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 0;
            double y = 0;

            var res = ds.Calculate(x, y);
            Assert.AreEqual(1.75, res);
        }
    }
}