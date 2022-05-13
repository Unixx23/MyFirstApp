using System;

internal class Homework5
{
    static void Main(string[] args)
    {
        string name = "Иванов";
        string surname = "Иван";
        string trueName = surname;
        surname = name;
        name = trueName;
    }
}

