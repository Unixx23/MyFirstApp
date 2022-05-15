using System;

internal class Program
{
    static void Main(string[] args)
    {
        int timeOfAcceptance = 10;
        Console.WriteLine("Введите количество людей в очереди:");
        int peopleInQueue = Convert.ToInt32(Console.Readline());
        int waitingTimeInHour = peopleInQueue * timeOfAcceptance / 60;
        int waitingTimeInMinute = peopleInWueue * timeOfAcceptance % 60;
        Console.WriteLine($"Время вашего нахождения в очереди составляет {waitingTimeInHour}ч {waitingTimeInMinute}минут");
    }
}

