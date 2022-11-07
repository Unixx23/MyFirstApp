using System;

internal class Homework3x7
{
    static void Main(string[] args)
    {
        string text = "которые разделены пробелом в тексте и вывести массив";
        string[] splitText = text.Split(' ');

        for (int i = 0; i < splitText.Length; i++)
        {
            Console.WriteLine(splitText[i]);
        }
    }
}

