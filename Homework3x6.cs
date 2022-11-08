using System;

internal class Homework3x6
{
    static void Main(string[] args)
    {
        int[] array = { 11, 5, 3, 7, 6, 8, 10, 0, 3, 15 };

		for (int i = 0; i < array.Length; i++)
		{
			for (int j = 0; j < array.Length - 1; j++)
			{
				if (array[j] > array[j + 1])
				{
					int tempNumber = array[j + 1];
					array[j + 1] = array[j];
					array[j] = tempNumber;
				}
			}
		}

		for (int i = 0; i < array.Length; i++)
        {
			Console.WriteLine(array[i]);
		}
	}		
}
