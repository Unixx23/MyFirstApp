using System;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите ваше имя:");
        string name = Console.ReadLine();
        Console.WriteLine("Сколько вам лет?");
        string age = Console.ReadLine();
        Console.WriteLine("Вы программист?");
        string work = Console.ReadLine();
        if (work == "нет")
        {
            Console.WriteLine($"Вас зовут {name}. Вам {age} лет. Вы учитесь на программиста.");
        }
        else
        {
            Console.WriteLine("Вас зовут " + name + ", Вам " + age + " лет. Вы программист");
        }
    }
}

