using tyuiu.cources.programming.interfaces.Sprint2;
 
namespace Tyuiu.GalchinskayaVV.Sprint2.Task2.V16.Lib
{
    public class DataService : ISprint2Task2V16
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            int[][] res = {
            new int [] {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
            new int [] {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
            new int [] {0,0,1,1,1,0,0,0,0,0,0,0,1,1,0},
            new int [] {0,0,1,1,1,0,0,0,0,0,0,0,1,1,0},
            new int [] {0,0,1,1,1,1,1,0,0,0,0,0,1,1,0},
            new int [] {0,0,1,1,1,1,1,1,1,0,0,0,1,1,0},
            new int [] {0,0,1,1,1,1,1,1,1,1,1,1,1,1,0},
            new int [] {0,0,0,0,0,1,1,1,1,0,0,0,1,1,0},
            new int [] {0,0,0,0,0,1,1,0,0,0,0,0,1,1,0},
            new int [] {0,0,0,0,0,1,1,0,0,0,0,0,1,1,0},
            new int [] {0,0,1,1,1,1,1,0,0,0,0,0,0,0,0},
            new int [] {0,0,1,0,0,0,1,1,1,1,0,0,0,0,0},
            new int [] {0,0,1,0,0,0,0,0,0,1,1,1,0,0,0},
            new int [] {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
            new int [] {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
            };
            return Convert.ToBoolean(res[x - 1][y - 1]);
        }

        public bool IsInArea(int v1, int v2)
        {
            throw new NotImplementedException();
        }
    }
}
