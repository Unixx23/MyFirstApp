using System;

internal class Homework28
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int randomNumber = random.Next(1, 28);
        int multiplyOfRandomNumber = randomNumber;
        int sum = 0;
        Console.WriteLine("Число от 1 до 27: " + randomNumber);

        for (int threeDigitNumbers = 100; threeDigitNumbers<101; multiplyOfRandomNumber+=randomNumber)
        {
            if (multiplyOfRandomNumber == threeDigitNumbers)
            {
                sum++;
                threeDigitNumbers++;
            }
        }

        Console.WriteLine("Количество трехзначных чисел, кратных числу " + randomNumber + ": " + sum);
    }
}

