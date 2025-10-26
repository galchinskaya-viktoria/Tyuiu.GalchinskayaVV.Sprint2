using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GalchinskayaVV.Sprint2.Task7.V2.Lib;

namespace Tyuiu.GalchinskayaVV.Sprint2.Task7.V2.Test
{
    [TestClass]
    public class Test1
    {
        [TestMethod]
        public void OnBoundaryIncluded()
        {
            var c = new Class1();
            // точка на окружности и на прямой: x=0.8944, y=0.4472 -> НЕ проходит, ниже прямой нужно
            Assert.IsFalse(c.IsInside(0.89442719, 0.4472136));
            // точка на окружности, ниже прямой
            Assert.IsTrue(c.IsInside(0.89442719, -0.4472136));
            // центр (0,0) — внутри и ниже прямой
            Assert.IsTrue(c.IsInside(0, 0));
        }
    }
}
