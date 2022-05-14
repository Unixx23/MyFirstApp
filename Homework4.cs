using System;

internal class Homework4
{
    static void Main(string[] args)
    {
        int pictures = 52;
        int rowOfPictures = 3;
        int totalRows = pictures / row;
        int surplus = pictures % row;
        Console.WriteLine($"Полностью заполненных рядов будет {totalRows}. Изображений останется {surplus}.");
    }
}

