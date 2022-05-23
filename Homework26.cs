using System;

internal class Homework26
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите '1', чтобы написать заметку");
        Console.WriteLine("Введите '2', чтобы просмотреть заметку");
        Console.WriteLine("Введите '3', чтобы установить пароль");
        Console.WriteLine("Введите '4', чтобы сбросить пароль");
        Console.WriteLine("Введите '5', если хотите выйти");
        string password = "0";
        string message = "Вы еще не написали заметку";
        string passwordInput;
        string userInput = "";
        bool check;

        while(userInput  != "5")
        {
            Console.Write("Выберите пункт меню: ");
            userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    if(password == "0")
                    {
                        Console.Write("Заметка:");
                        message = Console.ReadLine();
                    }
                    else
                    {
                        Console.Write("Введите пароль:");
                        passwordInput = Console.ReadLine();
                        check = password == passwordInput;

                        if (check)
                        {
                            Console.Write("Заметка:");
                            message = Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Вы ввели неправильный пароль");
                        }
                    }
                    break;
                case "2":
                    if (password == "0")
                    {
                        Console.WriteLine(message);
                    }
                    else
                    {
                        Console.Write("Введите пароль:");
                        passwordInput = Console.ReadLine();
                        check = password == passwordInput;

                        if (check)
                        {
                            Console.WriteLine(message);
                        }
                        else
                        {
                            Console.WriteLine("Вы ввели неправильный пароль");
                        }
                    }
                    break;
                case "3":
                    Console.WriteLine("Установите пароль:");
                    password = Console.ReadLine();
                    Console.WriteLine("Пароль сохранен.");
                    break;
                case "4":
                    if (password == "0")
                    {
                        Console.WriteLine("Пароль не был установлен");
                    }
                    else
                    {
                        Console.Write("Введите пароль:");
                        passwordInput = Console.ReadLine();
                        check = password == passwordInput;

                        if (check)
                        {
                            password = "0";
                            Console.WriteLine("Пароль сброшен");
                        }
                        else
                        {
                            Console.WriteLine("Вы ввели неверный пароль");
                        }
                    }
                    break;
            }
        }
        Console.WriteLine("До свидания");
    }
}

