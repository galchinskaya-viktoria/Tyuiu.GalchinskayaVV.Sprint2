using System;
using System.Globalization;
using Tyuiu.GalchinskayaVV.Sprint2.Task7.V2.Lib;

Console.Title = "Спринт #2 | Таск #2 | Вариант #2 | Выполнил: Гальчинская В.В. | ПКТб-25-1";
Console.Write("Введите X: ");
double x = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
Console.Write("Введите Y: ");
double y = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

var cls = new DataService();
bool inside = cls.CheckDotInShadedArea(x, y);

Console.WriteLine(inside ? "Точка в области" : "Точка вне области");
Console.ReadKey();
