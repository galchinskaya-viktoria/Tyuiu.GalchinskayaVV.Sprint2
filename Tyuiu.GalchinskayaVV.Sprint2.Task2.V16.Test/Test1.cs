using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GalchinskayaVV.Sprint2.Task2.V16.Lib;
 
namespace Tyuiu.GalchinskayaVV.Sprint2.Task2.V16.Test
{
    [TestClass]
    public class Test1
    {
        [TestMethod]
        public void CheckBounds()
        {
            var ds = new Class1();
            Assert.IsFalse(ds.IsInside(0, 1));
            Assert.IsFalse(ds.IsInside(16, 15));
            Assert.IsFalse(ds.IsInside(1, 0));
            Assert.IsFalse(ds.IsInside(15, 16));
        }

    }
}
