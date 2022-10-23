using System;

internal class Homework3x2
{
    static void Main(string[] args)
    {
        int[,] array = new int[10,10]; 
        Random random = new Random();
        int maxElement = int.MinValue;
        int minimumRandomNumber = 0;
        int maximumRandomNumber = 100;
        int replacingNumber = 0;

        for(int i = 0; i < array.GetLength(0); i++)
        {
            for(int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = random.Next(minimumRandomNumber,maximumRandomNumber);
                Console.Write(array[i, j] + " ");
            }
            
            Console.WriteLine();
        }


        for(int i = 0;i < array.GetLength(0); i++)
        {
            for(int j = 0;j < array.GetLength(1); j++)
            {
                if (maxElement < array[i, j])
                {
                    maxElement = array[i, j];
                }
            }
        }

        Console.WriteLine($"\nНаибольший елемент {maxElement}\n");

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (maxElement == array[i, j])
                {
                    array[i, j] = replacingNumber;
                }
            }
        }

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }

            Console.WriteLine();
        }
    }
}

