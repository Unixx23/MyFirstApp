using System;

internal class Homework24
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int randomNumber = random.Next(0, 101);
        int denominator1 = 3;
        int denominator2 = 5;
        int sum = 0;

        Console.WriteLine($"Случайное число: {randomNumber}");

        for (int number = 0; number < randomNumber; number++)
        {
            if(number % denominator1 == 0 || number % denominator2 == 0)
            {
                sum += number;
            }
        }
        sum += randomNumber;
        Console.WriteLine($"Сумма всех положительных чисел меньше {randomNumber}, (включая {randomNumber}), кратных {denominator1} и {denominator2}, равна {sum}");
    }
}

