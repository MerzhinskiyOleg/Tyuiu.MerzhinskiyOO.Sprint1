using Tyuiu.MerzhinskiyOO.Sprint1.Task3.V15.Lib;

namespace Tyuiu.MerzhinskiyOO.Sprint1.Task3.V15.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double v1 = 20;
            double v2 = 30;
            double S = 50;
            double T = 2;
            var res = ds.DistanceOverTime(v1, v2, S, T);
            double wait = 150;
            Assert.AreEqual(wait, res);
        }
    }
}