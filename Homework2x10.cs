using System;

internal class Homework2x10
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int randomNumber = random.Next();
        int number = 2;
        int power = 0;
        double resoult = Math.Pow(number,power);

        while(resoult<=randomNumber)
        {
            power++;
            resoult = Math.Pow(number, power);
        }

        Console.WriteLine($"Минимальная степень числа {number}, результат которого превосходит случайное число: {randomNumber}, - {power}");
        Console.WriteLine($"Результат возведения в степень {power}: {resoult}");
    }
}

