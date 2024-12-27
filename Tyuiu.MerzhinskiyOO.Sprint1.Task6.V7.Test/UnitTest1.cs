using Tyuiu.MerzhinskiyOO.Sprint1.Task6.V7.Lib;

namespace Tyuiu.MerzhinskiyOO.Sprint1.Task6.V7.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string h = "Яѓър";
            var result = ds.DeleteLastLetter(h);
            Assert.AreEqual("Яѓъ", result);
        }
    }
}