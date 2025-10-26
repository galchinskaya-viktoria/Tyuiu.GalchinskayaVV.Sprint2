using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.GalchinskayaVV.Sprint2.Task5.V2.Lib
{
    public class Class1 : ISprint2Task5V2
    {
        public string FindSeason(int month)
        {
            string season;

            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    season = "Зима";
                    break;
                case 3:
                case 4:
                case 5:
                    season = "Весна";
                    break;
                case 6:
                case 7:
                case 8:
                    season = "Лето";
                    break;
                case 9:
                case 10:
                case 11:
                    season = "Осень";
                    break;
                default:
                    season = "Ошибка: номер месяца должен быть от 1 до 12";
                    break;
            }

            return season;
        }
    }
}
