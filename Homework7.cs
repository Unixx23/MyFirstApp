using System;

internal class Program
{
    static void Main(string[] args)
    {
        int acceptanceTime = 10;
        Console.WriteLine("Введите количество людей в очереди:");
        int peopleInQueue = Convert.ToInt32(Console.Readline());
        int waitingTimeInHour = peopleInQueue * acceptanceTime / 60;
        int waitingTimeInMinute = peopleInWueue * acceptanceTime % 60;
        Console.WriteLine($"Время вашего нахождения в очереди составляет {waitingTimeInHour}ч {waitingTimeInMinute}минут");
    }
}

