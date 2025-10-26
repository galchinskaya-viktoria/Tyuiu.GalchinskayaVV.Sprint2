using System;
using Tyuiu.GalchinskayaVV.Sprint2.Task5.V2.Lib;

Console.Title = "Спринт #2 | Таск #5 | Вариант #2 | Выполнил: Гальчинская В.В. | ПКТб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Оператор switch                                                   *");
Console.WriteLine("* Задание #5                                                              *");
Console.WriteLine("* Вариант #2                                                              *");
Console.WriteLine("* Выполнил: Гальчинская Виктория Владимировна | ПКТб-25-1                 *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* По номеру месяца определить пору года.                                  *");
Console.WriteLine("***************************************************************************");

Console.Write("Введите номер месяца (1–12): ");
int month = Convert.ToInt32(Console.ReadLine());

Class1 ds = new Class1();
string result = ds.FindSeason(month);

Console.WriteLine("***************************************************************************");
Console.WriteLine($"Результат: {result}");
Console.ReadKey();

