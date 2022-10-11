using System;

internal class Homework2x7
{
    static void Main(string[] args)
    {
        Console.Write("Введите имя: ");
        string name = Console.ReadLine();
        Console.Write("Введите символ: ");
        char symbol = Convert.ToChar(Console.ReadLine());
        string stringOfSymbols = "";

        for (int length = -1; length <= name.Length; length++)
        {
            stringOfSymbols += symbol;
        }
        
        Console.WriteLine(stringOfSymbols);
        Console.WriteLine(symbol + name + symbol);
        Console.WriteLine(stringOfSymbols);
    }
}

