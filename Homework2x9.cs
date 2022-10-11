using System;

internal class Homework2x9
{
    static void Main(string[] args)
    {
        int minimumValueOfRandomNumber = 1;
        int maximumValueOfRandomNumber = 27;
        Random random = new Random();
        int randomNumber = random.Next(minimumValueOfRandomNumber, maximumValueOfRandomNumber+1);
        int amountOfNumbers = 0;
        int minimumValueOfMultiplyOfRandomNumber = 100;
        int maximumValueOfMultiplyOfRandomNumber = 999;
        Console.WriteLine($"Число от {minimumValueOfRandomNumber} до {maximumValueOfRandomNumber}: {randomNumber}");

        for (int multiplyOfRandomNumber = 0; multiplyOfRandomNumber <=maximumValueOfMultiplyOfRandomNumber; multiplyOfRandomNumber+=randomNumber)
        {
            if (multiplyOfRandomNumber >= minimumValueOfMultiplyOfRandomNumber)
            {
                amountOfNumbers++;
            }
        }

        Console.WriteLine("Количество трехзначных чисел, кратных числу " + randomNumber + ": " + amountOfNumbers);
    }
}

