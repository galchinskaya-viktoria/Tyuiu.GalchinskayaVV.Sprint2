using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.GalchinskayaVV.Sprint2.Task3.V4.Lib
{
    // Интерфейс ожидается вида ISprint2Task3V4 с методом Calculate(double x).
    public class Class1 : ISprint2Task3V4
    {
        public double Calculate(double x)
        {
            // y = {
            //   x + ((x+1)/(x-1))^x,                      если x > 1
            //   (x^2 + cos(x^2)) / (x^2 - sin(x^2) + 12), если x = 0
            //   (x - 1/x^2)^x,                            если -8 < x < 0
            //   x + 10x - (1/x),                          если x < -8
            //   иначе: (x^2 + cos(x^2)) / (x^2 - sin(x^2) + 12)   // по шаблону
            // }
            double y;
            if (x > 1)
            {
                y = x + Math.Pow((x + 1.0) / (x - 1.0), x);
            }
            else if (x == 0)
            {
                double t = x * x;
                y = (t + Math.Cos(t)) / (t - Math.Sin(t) + 12.0);
            }
            else if (x > -8 && x < 0)
            {
                y = Math.Pow(x - 1.0 / (x * x), x);
            }
            else if (x < -8)
            {
                y = x + 10.0 * x - 1.0 / x; // 11x - 1/x
            }
            else
            {
                // Незаполнённые из рисунка случаи: x ∈ (0;1] и x = -8
                double t = x * x;
                y = (t + Math.Cos(t)) / (t - Math.Sin(t) + 12.0);
            }

            return y;
        }
    }
}
