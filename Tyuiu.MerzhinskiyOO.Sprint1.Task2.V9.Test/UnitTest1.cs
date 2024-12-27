using Tyuiu.MerzhinskiyOO.Sprint1.Task2.V9.Lib;
namespace Tyuiu.MerzhinskiyOO.Sprint1.Task2.V9.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new();
            Assert.AreEqual(dataService.CalculateVolumeCircle(12), 7234.56);
        }
    }
}