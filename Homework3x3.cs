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

        for (int i = 0; i < array.Length; i++)
        {
            if (i == 0)
            {
                if (array[0] > array[1])
                {
                    Console.WriteLine(array[0]);
                }
                continue;
            }

            if (i == array.Length-1)
            {
                if (array[array.Length - 1] > array[array.Length - 2])
                {
                    Console.WriteLine(array[array.Length - 1]);
                }
                break;
            }

            if (array[i] > array[i-1] & array[i] > array[i + 1])
            {
                Console.WriteLine(array[i]);
                continue;
            }
        }
    }
}

