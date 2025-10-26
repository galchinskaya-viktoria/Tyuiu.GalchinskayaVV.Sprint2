using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.GalchinskayaVV.Sprint2.Task0.V7.Lib
{
    public class DataService : ISprint2Task0V7
    {
        public bool[] GetCompareOperations(int x, int y)
        {

            var results = new bool[6];

            // Логические операции
            results[0] = (x == x);              // False
            results[1] = (x != x);              // True
            results[2] = (x < y);               // True
            results[3] = (y > x);               // False
            results[4] = (x <= y);              // True
            results[5] = (x >= y);              // False

            return results;
        }

        public bool[] GetLogicOperations(int x, int y)
        {
            throw new NotImplementedException();
        }
    }


}
