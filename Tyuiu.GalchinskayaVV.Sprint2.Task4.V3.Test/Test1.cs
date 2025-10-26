using Tyuiu.GalchinskayaVV.Sprint2.Task4.V3.Lib;

namespace Tyuiu.GalchinskayaVV.Sprint2.Task4.V3.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
        
            var ds = new Class1();
            double x = 1, y = 5; // x < y-1 -> 1 < 4
            double expected = Math.Round(y + (y - 1.0) / (x + 2.0), 3, MidpointRounding.AwayFromZero);
            Assert.AreEqual(expected, ds.Calculate(x, y));
        }

        [TestMethod]
        public void Branch_CondFalse()
        {
            var ds = new Class1();
            double x = 5, y = 5; // 5 < 4 -> false
            double expected = Math.Round(x + 2.0 * y * (1.0 / (y + 3.0)), 3, MidpointRounding.AwayFromZero);
            Assert.AreEqual(expected, ds.Calculate(x, y));
        }
    }
}
