using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.GalchinskayaVV.Sprint2.Task1.V17.Lib
{
    public class Class1 : ISprint2Task1V17
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            var r = new bool[6];

            // Используем сравнения (==, !=, <, >, <=, >=) и логические (|, &, ||, &&, !, ^)
            r[0] = (a == b) | (c > d);                 // False | True  -> True
            r[1] = (a != b) & (c < d);                 // True  & False -> False
            r[2] = (a <= b) || (c >= d);                 // False || True -> True
            r[3] = (a > b) && ((c - d) > 0);            // True  && True -> True
            r[4] = !(d < b);                            // !(False)      -> True
            r[5] = (a != b) ^ (c != d);                 // True  ^ True  -> False

            return r;
        }
    }
}
