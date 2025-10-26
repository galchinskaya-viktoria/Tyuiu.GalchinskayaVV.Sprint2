using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GalchinskayaVV.Sprint2.Task5.V2.Lib;
 
namespace Tyuiu.GalchinskayaVV.Sprint2.Task5.V2.Test
{
    [TestClass]
    public class Test1
    {
        [TestMethod]
        public void TestWinterMonth()
        {
            var ds = new Class1();
            Assert.AreEqual("Зима", ds.FindSeason(1));
        }

        [TestMethod]
        public void TestSpringMonth()
        {
            var ds = new Class1();
            Assert.AreEqual("Весна", ds.FindSeason(4));
        }

        [TestMethod]
        public void TestSummerMonth()
        {
            var ds = new Class1();
            Assert.AreEqual("Лето", ds.FindSeason(8));
        }

        [TestMethod]
        public void TestAutumnMonth()
        {
            var ds = new Class1();
            Assert.AreEqual("Осень", ds.FindSeason(10));
        }

        [TestMethod]
        public void TestInvalidMonth()
        {
            var ds = new Class1();
            Assert.AreEqual("Ошибка: номер месяца должен быть от 1 до 12", ds.FindSeason(15));
        }
    }
}

