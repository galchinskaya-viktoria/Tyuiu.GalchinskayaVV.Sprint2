using System;
using Tyuiu.GalchinskayaVV.Sprint2.Task2.V16.Lib;
 
Console.Title = "Спринт #2 | Таск #2 | Вариант #16 | Выполнил: Гальчинская Виктория Владимировна | ПКТб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Логические выражения. Проверка попадания точки в область          *");
Console.WriteLine("* Задание #2                                                              *");
Console.WriteLine("* Вариант #16                                                             *");
Console.WriteLine("* Выполнил: Гальчинская Виктория Владимировна | ПКТб-25-1                 *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ: Написать программу, которая определяет, находится ли точка с   *");
Console.WriteLine("* координатами (X,Y) в заштрихованной области.                            *");
Console.WriteLine("***************************************************************************");

int x, y;
x = Convert.ToInt32(Console.ReadLine());
y = Convert.ToInt32(Console.ReadLine());
if (ds.CheckDotInShadedArea(x, y))
    Console.WriteLine("Точка находится" + ds.CheckDotInShadedArea(x, y));
else
    Console.WriteLine("Точка не находится" + ds.CheckDotInShadedArea(x, y));
