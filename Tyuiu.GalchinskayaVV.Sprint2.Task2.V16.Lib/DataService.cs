using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.GalchinskayaVV.Sprint2.Task2.V16.Lib
{
    public class DataService : ISprint2Task2V16
    {
        // Метод из интерфейса — принимает координаты точки
        public bool IsInArea(int x, int y)
        {
            // Проверка выхода за пределы поля
            if (x < 1 || x > 15 || y < 1 || y > 15)
                return false;

            // Ниже приведён пример логической карты из рисунка.
            // true — заштрихованные клетки (пример, не точная маска).
            bool[,] mask = new bool[15, 15]
            {
                // Строки сверху вниз (y=1..15), столбцы слева направо (x=1..15)
                { false,false,false,false,false,false,false,false,false,false,false,false,false,false,false },
                { false,false,false,false,false,false,false,false,false,false,false,false,false,false,false },
                { false,false,true,true,true,false,false,false,false,false,false,false,false,false,false },
                { false,false,true,false,true,false,false,false,false,false,false,false,false,false,false },
                { false,false,true,true,true,true,true,true,false,false,false,false,false,false,false },
                { false,false,false,false,false,false,false,true,false,false,false,false,false,false,false },
                { false,false,false,false,false,false,false,true,false,false,false,false,false,false,false },
                { false,false,false,false,false,false,true,true,true,true,true,false,false,false,false },
                { false,false,false,false,false,false,false,false,false,false,false,false,false,false,false },
                { false,false,false,false,false,false,false,false,false,false,false,false,false,false,false },
                { false,false,true,true,true,true,true,false,false,false,false,false,false,false,false },
                { false,false,true,false,false,false,false,false,false,false,false,false,false,false,false },
                { false,false,true,true,true,false,false,false,false,false,false,false,false,false,false },
                { false,false,false,false,false,false,false,false,false,false,false,false,false,false,false },
                { false,false,false,false,false,false,false,false,false,false,false,false,false,false,false }
            };

            // Индексы с нуля
            return mask[y - 1, x - 1];
        }
    }
}
