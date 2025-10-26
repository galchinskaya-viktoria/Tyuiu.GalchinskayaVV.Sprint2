using System;
using Tyuiu.GalchinskayaVV.Sprint2.Task6.V15.Lib;

Console.Title = "Спринт #2 | Задание #6 | Вариант #15 | Выполнил: Гальчинская В.В. | ПКТб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Сокращённая форма switch (switch expression)                      *");
Console.WriteLine("* Задание #6                                                              *");
Console.WriteLine("* Вариант #15                                                             *");
Console.WriteLine("***************************************************************************");
Console.Write("Введите k (1..365): ");
int k = Convert.ToInt32(Console.ReadLine());

var ds = new Class1();
string day = ds.FindDayName(k);

Console.WriteLine("***************************************************************************");
Console.WriteLine($"Результат: {day}");
Console.ReadKey();