using System;

internal class Homework3x6
{
    static void Main(string[] args)
    {
        int[] array = { 11, 5, 3, 7, 6, 8, 10, 0, 2, 15 };
        int[] arrayCopy = array;

        while (arrayCopy.Length > 0)
        {
            int count = 0;
            int minimumElement = int.MaxValue;
            int[] tempArray = new int[arrayCopy.Length - 1];

            for (int i = 0; i < arrayCopy.Length; i++)
            {
                if (arrayCopy[i] < minimumElement)
                {
                    minimumElement = arrayCopy[i];
                }
            }

            Console.Write(minimumElement + " ");

            for (int i = 0; i < arrayCopy.Length - 1; i++)
            {


                if (arrayCopy[i] != minimumElement)
                {
                    tempArray[i] = arrayCopy[i + count];
                }
                else
                {
                    count++;
                    tempArray[i] = arrayCopy[i + count];
                }
            }

            arrayCopy = tempArray;
        }
    }
}
