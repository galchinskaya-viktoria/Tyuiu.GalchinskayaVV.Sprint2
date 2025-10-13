using Tyuiu.GalchinskayaVV.Sprint2.Task0.V7.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #2 | Выполнил: Гальчинская Виктория Владимировна | ПКТб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Логические операции                                               *");
        Console.WriteLine("* Задание #1                                                              *");
        Console.WriteLine("* Вариант #7                                                              *");
        Console.WriteLine("* Выполнил: Гальчинская Виктория Владимировна | ПКТб-25-1                 *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу из операций сравнений и логических операций,         *");
        Console.WriteLine("* которая вернет массив: (True, False, True, True, True, False)           *");
        Console.WriteLine("* при x = 103, y = 475                                                   *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int x = 103, y = 475;
        Console.WriteLine("X = " + x);
        Console.WriteLine("Y = " + y);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        var ds = new DataService();
        bool[] result = ds.GetLogicOperations(x, y);

        for (int i = 0; i < result.Length; i++)
        {
            Console.WriteLine($"Операция {i + 1}: {result[i]}");
        }

        Console.ReadKey();
    }
}
