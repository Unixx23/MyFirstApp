using System;

internal class Homework21
{
    static void Main(string[] args)
    {
        Console.Write("Введите сообщение:");
        string message = Console.ReadLine();
        Console.WriteLine("Сколько раз его повторить?");
        
        for(int repeats = Convert.ToInt32(Console.ReadLine()); repeats>0;repeats--)
        {
            Console.WriteLine(message);
        }
    }
}

