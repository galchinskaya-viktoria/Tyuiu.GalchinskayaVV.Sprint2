using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.GalchinskayaVV.Sprint2.Task7.V2.Lib
{

    public class DataService : ISprint2Task7V2
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool inCircle = x * x + y * y <= 1.0;
            bool belowLine = y <= x / 2.0;
            return inCircle && belowLine;
        }
    }

}