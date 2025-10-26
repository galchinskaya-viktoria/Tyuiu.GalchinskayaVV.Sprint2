namespace Tyuiu.GalchinskayaVV.Sprint2.Task1.V16.Lib
{
    // Координаты: X — столбец 1..15 слева направо, Y — строка 1..15 сверху вниз.
    // Вставь свою маску по рисунку: true = закрашено, false = пусто.
    public class Class1
    {
        // Шаблон. ЗАМЕНИ содержимое на реальную маску для варианта 16.
        // 15 строк по 15 значений в каждой.
        private static readonly bool[,] Mask = new bool[15, 15]
        {
            // Y=1
            { false,false,false,false,false,false,false,false,false,false,false,false,false,false,false },
            // Y=2
            { false,false,false,false,false,false,false,false,false,false,false,false,false,false,false },
            // Y=3
            { false,false,false,false,false,false,false,false,false,false,false,false,false,false,false },
            // Y=4
            { false,false,false,false,false,false,false,false,false,false,false,false,false,false,false },
            // Y=5
            { false,false,false,false,false,false,false,false,false,false,false,false,false,false,false },
            // Y=6
            { false,false,false,false,false,false,false,false,false,false,false,false,false,false,false },
            // Y=7
            { false,false,false,false,false,false,false,false,false,false,false,false,false,false,false },
            // Y=8
            { false,false,false,false,false,false,false,false,false,false,false,false,false,false,false },
            // Y=9
            { false,false,false,false,false,false,false,false,false,false,false,false,false,false,false },
            // Y=10
            { false,false,false,false,false,false,false,false,false,false,false,false,false,false,false },
            // Y=11
            { false,false,false,false,false,false,false,false,false,false,false,false,false,false,false },
            // Y=12
            { false,false,false,false,false,false,false,false,false,false,false,false,false,false,false },
            // Y=13
            { false,false,false,false,false,false,false,false,false,false,false,false,false,false,false },
            // Y=14
            { false,false,false,false,false,false,false,false,false,false,false,false,false,false,false },
            // Y=15
            { false,false,false,false,false,false,false,false,false,false,false,false,false,false,false },
        };

        public bool IsInside(int x, int y)
        {
            if (x < 1 || x > 15 || y < 1 || y > 15) return false;
            // индексация массива с нулей: [y-1, x-1]
            return Mask[y - 1, x - 1];
        }
    }
}
