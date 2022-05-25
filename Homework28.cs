using System;

internal class Homework28
{
    static void Main(string[] args)
    {
        string password = "пароль";
        bool isCorrect;
        string secretMessage = ("Печеньки хранятся в банке с надписью 'крупа' ;)");
        Console.Write("Введите пароль: ");
        string userInput = Console.ReadLine();
        isCorrect = password == userInput;

        if (isCorrect)
        {
            Console.WriteLine("Тайное послание: " + secretMessage);
        }
        else
        {
            Console.WriteLine("Пароль неверный. У вас осталось две попытки");
            Console.Write("Введите пароль: ");
            userInput = Console.ReadLine();
            isCorrect = password == userInput;

            if (isCorrect)
            {
                Console.WriteLine("Тайное послание: " + secretMessage);
            }
            else
            {
                Console.WriteLine("Пароль неверный. У вас осталась одна попытка");
                Console.Write("Введите пароль: ");
                userInput = Console.ReadLine();
                isCorrect = password == userInput;

                if (isCorrect)
                {
                    Console.WriteLine("Тайное послание: " + secretMessage);
                }
            }
        }
    }
}

