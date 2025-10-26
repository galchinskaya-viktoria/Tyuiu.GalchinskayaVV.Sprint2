using System;
using tyuiu.cources.programming.interfaces.Sprint2;
using static System.Net.Mime.MediaTypeNames;

namespace Tyuiu.GalchinskayaVV.Sprint2.Task5.V2.Lib
{
    public class Class1 : ISprint2Task5V2
    {
        private int month;

        public string FindMonthSeason(int value)
        {
            string season;

            switch (month)
            {
                case 12:
                case 1:
                    season = "Зима";
                    break;
                case 2:
                    season = "Зима";
                    break;
                case 3:
                    season = "Весна";
                    break;
                case 4:
                    season = "Весна";
                    break;
                case 5:
                    season = "Весна";
                    break;
                case 6:
                    season = "Лето";
                    break;
                case 7:
                    season = "Лето";
                    break;
                case 8:
                    season = "Лето";
                    break;
                case 9:
                    season = "Осень";
                    break;
                case 10:
                    season = "Осень";
                    break;
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
