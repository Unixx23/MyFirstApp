using System;

internal class Homework3x1
{
    static void Main(string[] args)
    {
        int[,] array = new int[2,2];
        int sum = 0;
        int multiplication = 1;
        Random random = new Random();
        int lineNumber = 2;
        int columnNumber = 1;
        int minimumRandomNumber = 0;
        int maximumRandomNumber = 9;

        for(int i = 0; i < array.GetLength(0); i++)
        {
            for(int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = random.Next(minimumRandomNumber,maximumRandomNumber);
                Console.Write(array[i, j] + " ");
            }
            
            Console.WriteLine();
        }

        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[lineNumber - 1, i];
        }
        
        for (int i = 0; i < array.GetLength(1); i++)
        {
            multiplication *= array[i, columnNumber -1];
        }

        Console.WriteLine($"Результат сложения {lineNumber} строки равен {sum}");
        Console.WriteLine($"Результат умножения {columnNumber} столбца равен {multiplication}");
    }
}

