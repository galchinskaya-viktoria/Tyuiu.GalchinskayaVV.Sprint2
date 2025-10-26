using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GalchinskayaVV.Sprint2.Task3.V4.Lib;

namespace Tyuiu.GalchinskayaVV.Sprint2.Task3.V4.Test
{
    [TestClass]
    public class Test1
    {
        private static double R3(double v) => Math.Round(v, 3);

        [TestMethod]
        public void Branch_X_Greater_1()
        {
            var ds = new Class1();
            double x = 2.0;
            double expected = x + Math.Pow((x + 1) / (x - 1), x);
            Assert.AreEqual(R3(expected), R3(ds.Calculate(x)));
        }

        [TestMethod]
        public void Branch_X_Equals_0()
        {
            var ds = new Class1();
            double x = 0.0;
            double t = x * x;
            double expected = (t + Math.Cos(t)) / (t - Math.Sin(t) + 12.0);
            Assert.AreEqual(R3(expected), R3(ds.Calculate(x)));
        }

        [TestMethod]
        public void Branch_Minus8_Less_X_Less_0()
        {
            var ds = new Class1();
            double x = -4.0;
            double expected = Math.Pow(x - 1.0 / (x * x), x);
            Assert.AreEqual(R3(expected), R3(ds.Calculate(x)));
        }

        [TestMethod]
        public void Branch_X_Less_Minus8()
        {
            var ds = new Class1();
            double x = -10.0;
            double expected = x + 10.0 * x - 1.0 / x;
            Assert.AreEqual(R3(expected), R3(ds.Calculate(x)));
        }

        [TestMethod]
        public void Branch_Otherwise_UsesFraction()
        {
            var ds = new Class1();
            double x = 0.5; // попадает в «остальные случаи»
            double t = x * x;
            double expected = (t + Math.Cos(t)) / (t - Math.Sin(t) + 12.0);
            Assert.AreEqual(R3(expected), R3(ds.Calculate(x)));
        }
    }
}
