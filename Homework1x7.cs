using System;

internal class Program
{
    static void Main(string[] args)
    {
        int acceptanceTime = 10;
        int minutesInHour = 60;
        Console.WriteLine("Введите количество людей в очереди:");
        int peopleInQueue = Convert.ToInt32(Console.Readline());
        int waitingTimeInHours = peopleInQueue * acceptanceTime / minutesInHour;
        int waitingTimeInMinutes = peopleInQueue * acceptanceTime % minutesInHour;
        Console.WriteLine($"Время вашего нахождения в очереди составляет {waitingTimeInHours}ч {waitingTimeInMinutes}минут");
    }
}

