using System;

internal class Homework3x5
{
    static void Main(string[] args)
    {
        int[] array = new int[30];
        Random random = new Random();
        int minimumRandomNumber = 0;
        int maximumRandomNumber = 3;
        int repeatTimes = 1;
        int tempRepeatTimes = 1;
        int repeatNumber = 0;


        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(minimumRandomNumber, maximumRandomNumber);
            Console.Write(array[i]+" ");
        }

        for (int i = 0; i < array.Length - 1; i++)
        {
            int tempNumber = array[i];

            if (array[i] == array[i + 1])
            {
                tempRepeatTimes++;
            }
            else
            {
                if (repeatTimes < tempRepeatTimes)
                {
                    repeatTimes = tempRepeatTimes;
                    repeatNumber = tempNumber;
                }
                
                tempRepeatTimes = 1;
            }
        }

        Console.WriteLine("\nНаибольшее количество повторов подряд: "+ repeatTimes+" числа "+repeatNumber);
    }
}

