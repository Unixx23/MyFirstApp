using System;

internal class Homework27
{
    static void Main(string[] args)
    {
        Console.Write("Введите имя: ");
        string name = Console.ReadLine();
        Console.Write("Введите символ: ");
        char symbol = Convert.ToChar(Console.ReadLine());
        int length = -1;

        while (length++ < name.Length)
        {
            Console.Write(symbol);
        }
        Console.WriteLine(symbol);
        Console.WriteLine(symbol + name + symbol);
        length = -1;

        while (length++ < name.Length)
        {
            Console.Write(symbol);
        }
        Console.WriteLine(symbol);
    }
}

