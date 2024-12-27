using Tyuiu.MerzhinskiyOO.Sprint1.Task0.V10.Lib;
namespace Tyuiu.MerzhinskiyOO.Sprint1.Task0.V10.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(-10.5, res);
        }
    }
}