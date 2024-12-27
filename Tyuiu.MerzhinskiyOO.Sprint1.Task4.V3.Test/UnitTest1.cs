using Tyuiu.MerzhinskiyOO.Sprint1.Task4.V3.Lib;

namespace Tyuiu.MerzhinskiyOO.Sprint1.Task4.V3.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double x = 13;
            double y = 11;
            DataService ds = new DataService();
            double result = ds.Calculate(x, y);
            Assert.AreEqual(((Math.Sqrt(3 * x)) / (Math.Pow(x - y, 2))), result);
        }
    }
}