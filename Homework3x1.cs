using System;

internal class Homework3x1
{
    static void Main(string[] args)
    {
        int[,] array = new int[2,2];
        int sum = 0;
        int sum1 = 1;
        Random rand = new Random();

        for(int i = 0; i < array.GetLength(0); i++)
        {
            for(int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = rand.Next(0, 9);
                Console.Write(array[i, j] + " ");
            }
            
            Console.WriteLine();
        }

        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[1, i];
        }
        
        for (int i = 0; i < array.GetLength(1); i++)
        {
            sum1 *= array[i, 0];
        }

        Console.WriteLine($"Результат умножения второй строчки равен {sum}");
        Console.WriteLine($"Результат умножения первого столбца равен {sum1}");
    }
}

