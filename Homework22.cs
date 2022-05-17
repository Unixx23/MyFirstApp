using System;

internal class Homework22
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите сообщение:");
        string message = Console.ReadLine();
        
        while(message != "exit")
        {
            message = Console.ReadLine();
        }
    }
}

