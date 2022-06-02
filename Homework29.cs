using System;

internal class Homework29
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int randomNumber = random.Next(1, 28);
        int amountOfNumbers = 0;
        Console.WriteLine("Число от 1 до 27: " + randomNumber);

        for (int multiplyOfRandomNumber = 0; multiplyOfRandomNumber <1000; multiplyOfRandomNumber+=randomNumber)
        {
            if (multiplyOfRandomNumber > 99)
            {
                amountOfNumbers++;
            }
        }

        Console.WriteLine("Количество трехзначных чисел, кратных числу " + randomNumber + ": " + amountOfNumbers);
    }
}

