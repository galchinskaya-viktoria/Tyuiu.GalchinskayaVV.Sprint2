using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GalchinskayaVV.Sprint2.Task2.V16.Lib;
  
namespace Tyuiu.GalchinskayaVV.Sprint2.Task2.V16.Test
{
    [TestClass]
    public class Test1
    {
        [TestMethod]
        public void CheckInsidePoint()
        {
            var ds = new DataService();
            bool actual = ds.IsInArea(3, 3); // пример точки в области
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void CheckOutsidePoint()
        {
            var ds = new DataService();
            bool actual = ds.IsInArea(10, 2); // пример точки вне области
            Assert.IsFalse(actual);
        }
    }
}
