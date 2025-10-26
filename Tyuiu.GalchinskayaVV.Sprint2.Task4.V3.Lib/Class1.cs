using System;
using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.GalchinskayaVV.Sprint2.Task4.V3.Lib
{
    // z = (x < y - 1) ? y + (y - 1)/(x + 2) : x + 2*y*(1/(y + 3))
    public class Class1 : ISprint2Task4V3
    {
        public double Calculate(double x, double y)
        {
            double z = (x < y - 1)
                ? y + (y - 1.0) / (x + 2.0)
                : x + 2.0 * y * (1.0 / (y + 3.0));

            return Math.Round(z, 3, MidpointRounding.AwayFromZero);
        }
    }
}

