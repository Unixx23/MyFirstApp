using System;

internal class Homework1x4
{
    static void Main(string[] args)
    {
        int pictures = 52;
        int rowOfPictures = 3;
        int totalRows = pictures / rowOfPictures;
        int surplusOfPictures = pictures % rowOfPictures;
        Console.WriteLine($"Полностью заполненных рядов будет {totalRows}. Изображений останется {surplusOfPictures}.");
    }
}

