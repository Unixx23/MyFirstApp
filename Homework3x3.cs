using System;

internal class Homework3x3
{
    static void Main(string[] args)
    {
        int[] array = new int[30];
        Random random = new Random();
        int minimumRandomNumber = 0;
        int maximumRandomNumber = 100;

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(minimumRandomNumber, maximumRandomNumber);
            Console.Write(array[i] + " ");
        }

        Console.WriteLine("\nЛокальные максимумы массива: ");

        if (array[0] > array[1])
        {
                Console.WriteLine(array[0]);
        }

        for (int i = 1; i < array.Length-1; i++)
        {
            if (array[i] > array[i-1] & array[i] > array[i + 1])
            {
                Console.WriteLine(array[i]);
                continue;
            }
        }

        if (array[array.Length - 1] > array[array.Length - 2])
        {
                Console.WriteLine(array[array.Length - 1]);
        }
    }
}

