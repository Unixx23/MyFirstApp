using System;

internal class Homework4x1
{
    static void Main(string[] args)
    {
        bool isOpen = true;
        string[] names = {"Иван", "Петр", "Федор"};
        string[] surnames = {"Петров", "Иванов", "Сидоров"};
        int indexOfDossier = 0;

        while (isOpen)
        {
            Console.WriteLine("1 - Добавить досье");
            Console.WriteLine("2 - Вывести все досье");
            Console.WriteLine("3 - Удалить досье");
            Console.WriteLine("4 - Поиск досье");
            Console.WriteLine("5 - Выход");
            Console.Write("Выберите пункт меню:");

            int userInput = Convert.ToInt32(Console.ReadLine());

            switch (userInput)
            {
                case 1:
                    Console.Write("Введите имя: ");
                    string name = Console.ReadLine();
                    names = AddDossier(names, name);
                    Console.Write("Введите фамилию: ");
                    string surname = Console.ReadLine();
                    surnames = AddDossier(surnames, surname);
                    break;
                case 2:
                    WriteDossiers(names,surnames);
                    break;
                case 3:
                    Console.Write("Введите фамилию: ");
                    surname = Console.ReadLine();
                    Console.WriteLine("Вы действительно хотите удалить " + SearchDossier(names,surnames,surname,indexOfDossier) + "?");
                    surnames = DeliteDossier(surnames, surname);

                    break;
                case 4:
                    //поиск
                    Console.Write("Введите фамилию: ");
                    surname = Console.ReadLine();
                    Console.WriteLine(SearchDossier(names,surnames,surname,indexOfDossier));
                    break;
                case 5:
                    isOpen = false;
                    break;
            }
        }
    }

    static string[] AddDossier(string[] names, string name)
    {
        string[] tempNames = new string [names.Length+1];

        for(int i = 0; i < tempNames.Length-1; i++)
        {
            tempNames[i] = names[i];
        }

        tempNames[tempNames.Length - 1] = name;
        names = tempNames;
        return names;
    }

    static void WriteDossiers(string[] names, string[] surnames)
    {
        for (int i = 0; i < names.Length; i++)
        {
            Console.Write(i + 1 + ". ");
            Console.Write(names[i] + " - ");
            Console.Write(surnames[i] + "\n");
        }
    }

    static string[] DeliteDossier(string[] names,string name)
    {
        string[] tempNames = new string [names.Length];
        int count = 0;

        for (int i = 0; i < tempNames.Length - 1; i++)
        {
            if (names[i] != name)
            {
                tempNames[i-count] = names[i];
            }
            else
            {
                count++;
            }
        }

        names = tempNames;
        return names;
    }

    static string SearchDossier(string[] names,string[] surnames, string surname,int indexOfDossier)
    {
        for(int i = 0;i < surnames.Length; i++)
        {
            if(surnames[i] == surname)
            {
                indexOfDossier = i;
                break;
            }

            if (i == surnames.Length-1)
            {
                return "Досье не найдено";
            }
        }

        return $"Досье: {names[indexOfDossier]} - {surnames[indexOfDossier]}";
    }
}

