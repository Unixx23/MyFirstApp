using System;

internal class Homework4x1
{
    static void Main(string[] args)
    {
        bool isOpen = true;
        string[] fullNames = {"Иванов Иван Иванович", "Петров Петр Петрович", "Сидоров Сидор Сидорович"};
        string[] positions = {"Директор", "Бухгалтер", "Программист"};
        int indexOfDossier = 0;
        string surname = "";
        string dossierNotFound = "Досье не найдено";
        

        while (isOpen)
        {
            Console.WriteLine("1 - Добавить досье\n2 - Вывести все досье\n3 - Удалить досье\n4 - Поиск досье\n5 - Выход\n");
            Console.Write("Выберите пункт меню:");
            string userInput = Console.ReadLine();
            Console.WriteLine();

            switch (userInput)
            {
                case"1":
                    Console.Write("Введите фамилию: ");
                    string name = Console.ReadLine();
                    fullNames = AddDossier(fullNames, name);
                    Console.Write("Введите должность: ");
                    surname = Console.ReadLine();
                    positions = AddDossier(positions, surname);
                    break;
                case "2":
                    WriteDossiers(fullNames,positions);
                    Console.WriteLine("\nДля продолжения нажмите любую клавишу...");
                    Console.ReadKey();
                    break;
                case "3":
                    if (SearchDossier(positions, fullNames, ref surname, ref indexOfDossier) != dossierNotFound)
                    {
                        Console.WriteLine($"Выполняется удаление {indexOfDossier+1}. {fullNames[indexOfDossier]} - {positions[indexOfDossier]}...");
                        fullNames = DeliteDossier(fullNames, indexOfDossier);
                        positions = DeliteDossier(positions, indexOfDossier);
                        Console.WriteLine("Удаление завершено");
                    }
                    else
                    {
                        Console.WriteLine(dossierNotFound);
                    }

                    Console.WriteLine("\nДля продолжения нажмите любую клавишу...");
                    Console.ReadKey();
                    break;
                case "4":
                    Console.WriteLine(SearchDossier(fullNames,positions,ref surname,ref indexOfDossier));
                    Console.WriteLine("\nДля продолжения нажмите любую клавишу...");
                    Console.ReadKey();
                    break;
                case "5":
                    isOpen = false;
                    break;
            }

            Console.Clear();
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
            Console.Write(i + 1 + ". " + names[i] + " - " + surnames[i] + "\n");
        }
    }

    static string[] DeliteDossier(string[] names,int indexOfDossier)
    {
        string[] tempNames = new string [names.Length-1];
        int count = 0;

        for (int i = 0; i < names.Length; i++)
        {
            if (i != indexOfDossier)
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

    static string SearchDossier(string[] names,string[] surnames, ref string surname,ref int indexOfDossier)
    {
        Console.Write("Введите фамилию: ");
        surname = Console.ReadLine();

        for(int i = 0;i < surnames.Length; i++)
        {
            if(names[i].Contains(surname))
            {
                indexOfDossier = i;
                return $"Досье: {indexOfDossier+1}. {names[indexOfDossier]} - {surnames[indexOfDossier]}";
            }

            else
            {
                return "Досье не найдено";
            }
        }
       }
        }
      }

    }
}

