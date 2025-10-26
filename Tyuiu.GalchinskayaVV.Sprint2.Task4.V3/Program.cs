using System;
using System.Globalization;
using Tyuiu.GalchinskayaVV.Sprint2.Task4.V3.Lib;

Console.Title = "Спринт #2 | Задание #4 | Вариант #3 | Выполнил: Гальчинская В.В. | ПКТб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Тернарный оператор                                                *");
Console.WriteLine("* Задание #4                                                              *");
Console.WriteLine("* Вариант #3                                                              *");
Console.WriteLine("* Выполнил: Гальчинская Виктория Владимировна | ПКТб-25-1                 *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ: z = (x < y - 1) ? y + (y - 1)/(x + 2) : x + 2*y*(1/(y + 3))     *");
Console.WriteLine("* Округлить результат до 3 знаков.                                        *");
Console.WriteLine("***************************************************************************");

Console.Write("Введите x: ");
double x = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
Console.Write("Введите y: ");
double y = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

var ds = new Class1();
double z = ds.Calculate(x, y);

Console.WriteLine("***************************************************************************");
Console.WriteLine($"z = {z.ToString(CultureInfo.InvariantCulture)}");
Console.ReadKey();
