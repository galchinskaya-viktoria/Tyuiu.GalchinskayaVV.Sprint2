using System;
using Tyuiu.GalchinskayaVV.Sprint2.Task2.V16.Lib;

Console.Title = "Спринт #2 | Выполнил: Гальчинская Виктория Владимировна | ПКТб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Попадание точки в заштрихованную область                          *");
Console.WriteLine("* Задание #1                                                              *");
Console.WriteLine("* Вариант #16                                                             *");
Console.WriteLine("* Выполнил: Гальчинская Виктория Владимировна | ПКТб-25-1                 *");
Console.WriteLine("***************************************************************************");
Console.Write("Введите X (1..15): ");
int x = int.Parse(Console.ReadLine()!);
Console.Write("Введите Y (1..15): ");
int y = int.Parse(Console.ReadLine()!);

var ds = new Class1();
bool inside = ds.IsInside(x, y);
Console.WriteLine("***************************************************************************");
Console.WriteLine($"Точка {(inside ? "внутри" : "вне")} заштрихованной области");
Console.ReadKey();
