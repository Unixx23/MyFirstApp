using System;

internal class Homework21
{
    static void Main(string[] args)
    {
        Console.Write("Введите сообщение:");
        string message = Console.ReadLine();
        Console.WriteLine("Сколько раз его повторить?");
        int repeats = Convert.ToInt32(Console.ReadLine());
        
        while(repeats-->0)
        {
            Console.WriteLine(message);
        }
    }
}

