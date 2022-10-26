using System;

internal class Homework3x4
{
    static void Main(string[] args)
    {
        int[] array = new int[1];
        string userInput;
        int sum;
        bool isOpen = true;

        Console.WriteLine("Введите число, чтобы сохранить его");
        Console.WriteLine("Введите 'sum', чтобы сложить все, сохраненные числа");
        Console.WriteLine("Введите 'exit', чтобы выйти");

        while (isOpen)
        {            
            userInput = Console.ReadLine();

            if(userInput == "exit")
            {
                isOpen = false;
            }
            else if (userInput == "sum")
            {
                sum = 0;

                for (int i = 0; i < array.Length; i++)
                {
                    sum += array[i];
                }
                
                Console.WriteLine($"Сумма всех введенных чисел: {sum}");
            }
            else
            {
                array[array.Length-1] = Convert.ToInt32(userInput);
                int[] tempArray = new int[array.Length + 1];

                for (int i = 0; i < array.Length; i++)
                {
                    tempArray[i] = array[i];
                }

                array = tempArray;
            }
        }
    }
}

