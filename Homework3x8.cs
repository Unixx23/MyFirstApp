using System;

internal class Homework3x8
{
	static void Main(string[] args)
	{
		int[] array = { 1, 4, 6, 7, 8 };
		int userInput;

		Console.Write("Введите значение сдвига влево: ");
		userInput = Convert.ToInt32(Console.ReadLine());

		for (int i = 0; i < userInput; i++)
		{
			for (int j = 0; j < array.Length - 1; j++)
			{
				int tempNumber = array[j + 1];
				array[j + 1] = array[j];
				array[j] = tempNumber;
			}
		}

		for(int i = 0;i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
	}
}

