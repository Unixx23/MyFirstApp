using System;

internal class Homework3x2
{
    static void Main(string[] args)
    {
        int[,] A = new int[10,10]; 
        Random rand = new Random();
        int maxElement = int.MinValue;

        for(int i = 0; i < A.GetLength(0); i++)
        {
            for(int j = 0; j < A.GetLength(1); j++)
            {
                A[i, j] = rand.Next(0, 100);
                Console.Write(A[i, j] + " ");
            }
            
            Console.WriteLine();
        }


        for(int i = 0;i < A.GetLength(0); i++)
        {
            for(int j = 0;j < A.GetLength(1); j++)
            {
                if (maxElement < A[i, j])
                {
                    maxElement = A[i, j];
                }
            }
        }

        Console.WriteLine($"\nНаибольший елемент {maxElement}\n");

        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (maxElement == A[i, j])
                {
                    A[i, j] = 0;
                }
            }
        }

        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                Console.Write(A[i, j] + " ");
            }

            Console.WriteLine();
        }
    }
}

