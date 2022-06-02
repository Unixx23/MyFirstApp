using System;

internal class Homework29
{
    static void Main(string[] args)
    {
        int minimumValueOfRandomNumber = 1;
        int maximumValueOfRandomNumber = 27;
        Random random = new Random();
        int randomNumber = random.Next(minimumValueOfRandomNumber, maximumValueOfRandomNumber+1);
        int amountOfNumbers = 0;
        int minimumValueOfThreeDigitNumbers = 100;
        int maximumValueOfThreeDigitNumbers = 999;
        Console.WriteLine($"Число от {minimumValueOfRandomNumber} до {maximumValueOfRandomNumber}: {randomNumber}");

        for (int multiplyOfRandomNumber = 0; multiplyOfRandomNumber <=maximumValueOfThreeDigitNumbers; multiplyOfRandomNumber+=randomNumber)
        {
            if (multiplyOfRandomNumber >= minimumValueOfThreeDigitNumbers)
            {
                amountOfNumbers++;
            }
        }

        Console.WriteLine("Количество трехзначных чисел, кратных числу " + randomNumber + ": " + amountOfNumbers);
    }
}

