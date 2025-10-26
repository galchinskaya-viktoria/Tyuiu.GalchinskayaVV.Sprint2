using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GalchinskayaVV.Sprint2.Task6.V15.Lib;

namespace Tyuiu.GalchinskayaVV.Sprint2.Task6.V15.Test
{
    [TestClass]
    public class Test1
    {
        [TestMethod] public void Day1() { Assert.AreEqual("понедельник", new Class1().FindDayName(1)); }
        [TestMethod] public void Day2() { Assert.AreEqual("вторник", new Class1().FindDayName(2)); }
        [TestMethod] public void Day7() { Assert.AreEqual("воскресенье", new Class1().FindDayName(7)); }
        [TestMethod] public void Day8() { Assert.AreEqual("понедельник", new Class1().FindDayName(8)); }
        [TestMethod] public void Day365() { Assert.AreEqual("понедельник", new Class1().FindDayName(365)); }
        [TestMethod]
        public void OutOfRange()
        {
            Assert.AreEqual("ошибка", new Class1().FindDayName(0));
            Assert.AreEqual("ошибка", new Class1().FindDayName(366));
        }
    }
}
