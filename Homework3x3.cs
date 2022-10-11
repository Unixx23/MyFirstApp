using System;

internal class Homework3x3
{
    static void Main(string[] args)
    {
        int[] A = new int[30];
        Random rand = new Random();

        for (int i = 0; i < A.Length; i++)
        {
            A[i] = rand.Next(0, 100);
            Console.Write(A[i] + " ");
        }

        Console.WriteLine("\nЛокальные максимумы массива: ");

        for (int i = 0; i < A.Length; i++)
        {
            if (i == 0)
            {
                if (A[0] > A[1])
                {
                    Console.WriteLine(A[0]);
                }
                continue;
            }

            if (i == A.Length-1)
            {
                if (A[A.Length - 1] > A[A.Length - 2])
                {
                    Console.WriteLine(A[A.Length - 1]);
                }
                break;
            }

            if (A[i] > A[i-1] & A[i] > A[i + 1])
            {
                Console.WriteLine(A[i]);
                continue;
            }
        }
    }
}

