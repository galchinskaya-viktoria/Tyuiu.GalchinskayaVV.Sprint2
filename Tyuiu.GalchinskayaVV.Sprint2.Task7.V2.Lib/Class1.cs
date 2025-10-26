using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.GalchinskayaVV.Sprint2.Task7.V2.Lib
{
    // Требуемая доп. функция — здесь
    public class Class1: ISpint2Task7V2
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res = x * x + y * y <= 1.0 && y <= x / 2.0;
            return res;
        }
    }
}
