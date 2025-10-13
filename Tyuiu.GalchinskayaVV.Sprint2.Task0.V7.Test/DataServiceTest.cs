

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GalchinskayaVV.Sprint2.Task0.V7.Lib;

namespace Tyuiu.GalchinskayaVV.Sprint2.Task0.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetLogicOperations()
        {
            var ds = new DataService();
            int x = 103, y = 475;

            bool[] actual = ds.GetLogicOperations(x, y);
            bool[] expected = { false, true, true, false, true, false };

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
