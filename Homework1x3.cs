using System;

internal class Homework1x3
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите ваше имя:");
        string name = Console.ReadLine();
        Console.WriteLine("Сколько вам лет?");
        string age = Console.ReadLine();
        Console.WriteLine("Кем вы работаете?");
        string profession = Console.ReadLine();
        Console.WriteLine($"Вас зовут {name}. Вам {age} лет. Вы работаете {profession}");

    }
}

