using System;

internal class Homework2x11
{
    static void Main(string[] args)
    {
        string text = "()(()((())))";
        char bracket =')';
        int sumOfBrackets = 0;
        int maximumLevelOfBrackets = 0;

        Console.WriteLine(text);

        for(int i = 0; i < text.Length; i++)
        {
            if(text[i] == bracket)
            {
                sumOfBrackets--;
            }
            else
            {
                sumOfBrackets++;
            }

            if (sumOfBrackets == -1)
            {
                break;
            }

            if (sumOfBrackets > maximumLevelOfBrackets)
            {
                maximumLevelOfBrackets++;
            }
        }

        if (sumOfBrackets != 0)
        {
            Console.WriteLine("Выражение некорректно");
        }
        else
        {
            Console.WriteLine("Выражение корректно");
            Console.WriteLine("Максимальная глубина вложености скобочного выражения: " + maximumLevelOfBrackets);
        }
    }
}

