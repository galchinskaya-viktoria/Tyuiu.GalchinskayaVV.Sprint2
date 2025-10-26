using Tyuiu.GalchinskayaVV.Sprint2.Task5.V2.Lib;
using static Microsoft.ApplicationInsights.MetricDimensionNames.TelemetryContext;

namespace Tyuiu.GalchinskayaVV.Sprint2.Task6.V15.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var ds = new Class1();
            Assert.AreEqual("Зима", ds.FindMonthSeason(1));
        }
        [TestMethod]
        public void TestSpringMonth()
        {
            var ds = new Class1();
            Assert.AreEqual("Весна", ds.FindMonthSeason(4));
        }

        [TestMethod]
        public void TestSummerMonth()
        {
            var ds = new Class1();
            Assert.AreEqual("Лето", ds.FindMonthSeason(8));
        }

        [TestMethod]
        public void TestAutumnMonth()
        {
            var ds = new Class1();
            Assert.AreEqual("Осень", ds.FindMonthSeason(10));
        }

        [TestMethod]
        public void TestInvalidMonth()
        {
            var ds = new Class1();
            Assert.AreEqual("Ошибка: номер месяца должен быть от 1 до 12", ds.FindMonthSeason(15));
        }
     
    }
}