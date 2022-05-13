using System;

internal class Homework3
{
    static void Main(string[] args)
    {
        int pictures = 52;
        int line = 3;
        int sumLine = pictures / line;
        int surplus = pictures % line;
        Console.WriteLine($"Полностью заполненных рядов будет {sumLine}. Изображений останется {surplus}.");

    }
}

