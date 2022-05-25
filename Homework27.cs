using System;

internal class Homework27
{
    static void Main(string[] args)
    {
        Console.Write("Введите имя: ");
        string name = Console.ReadLine();
        Console.Write("Введите символ: ");
        char symbol = Convert.ToChar(Console.ReadLine());
        string stringOf = "";

        for (int length = -1; length <= name.Length; length++)
        {
            stringOf += symbol;
        }
        
        Console.WriteLine(stringOf);
        Console.WriteLine(symbol + name + symbol);
        Console.WriteLine(stringOf);
    }
}

