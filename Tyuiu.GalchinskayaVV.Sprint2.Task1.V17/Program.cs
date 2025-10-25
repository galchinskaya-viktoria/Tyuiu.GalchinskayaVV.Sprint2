using System;
using Tyuiu.GalchinskayaVV.Sprint2.Task1.V17.Lib;

Console.Title = "Спринт #2 | Выполнил: Гальчинская Виктория Владимировна | ПКТб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Логические операции                                               *");
Console.WriteLine("* Задание #1                                                              *");
Console.WriteLine("* Вариант #17                                                             *");
Console.WriteLine("* Выполнил: Гальчинская Виктория Владимировна | ПКТб-25-1                 *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ: вернуть (True, False, True, True, True, False)                 *");
Console.WriteLine("* при a = 135, b = 123, c = 455, d = 321                                  *");
Console.WriteLine("***************************************************************************");

int a = 135, b = 123, c = 455, d = 321;
Console.WriteLine($"A = {a}\nB = {b}\nC = {c}\nD = {d}");
Console.WriteLine("***************************************************************************");

var ds = new Class1();
bool[] res = ds.GetLogicOperations(a, b, c, d);
for (int i = 0; i < res.Length; i++) Console.WriteLine($"Операция {i + 1}: {res[i]}");

Console.ReadKey();
