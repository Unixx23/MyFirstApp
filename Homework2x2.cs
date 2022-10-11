using System;

internal class Homework2x2
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

