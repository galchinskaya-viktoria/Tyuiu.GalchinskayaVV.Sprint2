using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.GalchinskayaVV.Sprint2.Task6.V15.Lib
{
    public class Class1 : ISprint2Task6V15
    {
        // k: 1..365, 1 января — понедельник
        public string FindDayName(int k)
        {
            if (k < 1 || k > 365) return "ошибка";

            int idx = (k - 1) % 7; // 0..6
            return idx switch
            {
                0 => "Понедельник",
                1 => "Вторник",
                2 => "Среда",
                3 => "Четверг",
                4 => "Пятница",
                5 => "Cуббота",
                6 => "Воскресенье",
                _ => "Ошибка"
            };
        }
    }
}
