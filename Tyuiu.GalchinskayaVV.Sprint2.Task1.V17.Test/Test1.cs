using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GalchinskayaVV.Sprint2.Task1.V17.Lib;

namespace Tyuiu.GalchinskayaVV.Sprint2.Task1.V17.Test
{
    [TestClass]
    public class Test1
    {
        [TestMethod]
        public void ValidGetLogicOperations()
        {
            var ds = new Class1();
            int a = 135, b = 123, c = 455, d = 321;

            bool[] actual = ds.GetLogicOperations(a, b, c, d);
            bool[] expected = { true, false, true, true, true, false };

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
