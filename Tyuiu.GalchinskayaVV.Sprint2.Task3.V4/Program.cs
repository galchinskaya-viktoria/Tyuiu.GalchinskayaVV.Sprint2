using System;
using System.Globalization;
using Tyuiu.GalchinskayaVV.Sprint2.Task3.V4.Lib;

Console.Title = "Спринт #2 | Выполнил: Гальчинская Виктория Владимировна | ПКТб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Вложенные if-else. Разветвляющиеся алгоритмы                      *");
Console.WriteLine("* Задание #3                                                              *");
Console.WriteLine("* Вариант #4                                                              *");
Console.WriteLine("* Выполнил: Гальчинская Виктория Владимировна | ПКТб-25-1                 *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Вычислить y по кусочной функции. Округлить результат до 3 знаков.       *");
Console.WriteLine("***************************************************************************");

Console.Write("Введите X: ");
var str = Console.ReadLine();
double x = double.Parse(str!, CultureInfo.InvariantCulture);

var ds = new Class1();
double y = ds.Calculate(x);
Console.WriteLine("***************************************************************************");
Console.WriteLine($"Y = {Math.Round(y, 3).ToString(CultureInfo.InvariantCulture)}");
Console.ReadKey();

