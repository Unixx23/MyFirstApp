using System;

internal class Homework25
{
    static void Main(string[] args)
    {
        float dollars = 150f;
        float euro = 150f;
        float rubles = 150f;
        float dollarToEuro = 0.8f;
        float dollarToRuble = 80;
        float euroToDollar =1.25f;
        float euroToRuble = 100;
        float rubleToDollar = 0.015f;
        float rubleToEuro = 0.01f;
        float dollarsPrice;
        float euroPrice;
        float rublesPrice;
        int purchasedCurrency;
        
        Console.WriteLine("Добро пожаловать в обменник валют.");
        Console.WriteLine($"У вас на счету {dollars} долларов, {euro} евро, {rubles} рублей.");
        Console.WriteLine("Для обмена долларов на евро введите '1'");
        Console.WriteLine("Для обмена долларов на рубли введите '2'");
        Console.WriteLine("Для обмена евро на доллары введите '3'");
        Console.WriteLine("Для обмена евро на рубли введите '4'");
        Console.WriteLine("Для обмена рублей на доллары введите '5'");
        Console.WriteLine("Для обмена рублей на евро введите '6'");
        Console.WriteLine("Для выхода введите '7'");
        int userInput = Convert.ToInt32(Console.ReadLine());
        
        while(userInput  != 7)
        {
            switch (userInput)
            {
                case 1:
                    Console.WriteLine("Обмен долларов на евро");
                    Console.WriteLine("Сколько евро вы хотите купить?");
                    purchasedCurrency = Convert.ToInt32(Console.ReadLine());
                    euro += purchasedCurrency;
                    euroPrice = purchasedCurrency * euroToDollar;
                    dollars -= euroPrice;
                    Console.WriteLine($"Вы приобрели {purchasedCurrency} евро за {euroPrice} долларов");
                    break;
                case 2:
                    Console.WriteLine("Обмен долларов на рубли");
                    Console.WriteLine("Сколько рублей вы хотите купить?");
                    purchasedCurrency = Convert.ToInt32(Console.ReadLine());
                    rubles += purchasedCurrency;
                    rublesPrice = purchasedCurrency * rubleToDollar;
                    dollars -= rublesPrice;
                    Console.WriteLine($"Вы приобрели {purchasedCurrency} рублей за {rublesPrice} долларов");
                    break;
                case 3:
                    Console.WriteLine("Обмен евро на доллары");
                    Console.WriteLine("Сколько долларов вы хотите купить?");
                    purchasedCurrency = Convert.ToInt32(Console.ReadLine());
                    dollars += purchasedCurrency;
                    dollarsPrice = purchasedCurrency * dollarToEuro;
                    euro -= dollarsPrice;
                    Console.WriteLine($"Вы приобрели {purchasedCurrency} долларов за {dollarsPrice} евро");
                    break;
                case 4:
                    Console.WriteLine("Обмен евро на рубли");
                    Console.WriteLine("Сколько рублей вы хотите купить?");
                    purchasedCurrency = Convert.ToInt32(Console.ReadLine());
                    rubles += purchasedCurrency;
                    rublesPrice = purchasedCurrency * rubleToEuro;
                    euro -= rublesPrice;
                    Console.WriteLine($"Вы приобрели {purchasedCurrency} рублей за {rublesPrice} евро");
                    break;
                case 5:
                    Console.WriteLine("Обмен рублей на доллары");
                    Console.WriteLine("Сколько долларов вы хотите купить?");
                    purchasedCurrency = Convert.ToInt32(Console.ReadLine());
                    dollars += purchasedCurrency;
                    dollarsPrice = purchasedCurrency * dollarToRuble;
                    rubles -= dollarsPrice;
                    Console.WriteLine($"Вы приобрели {purchasedCurrency} долларов за {dollarsPrice} рублей");
                    break;
                case 6:
                    Console.WriteLine("Обмен рублей на евро");
                    Console.WriteLine("Сколько евро вы хотите купить?");
                    purchasedCurrency = Convert.ToInt32(Console.ReadLine());
                    euro += purchasedCurrency;
                    euroPrice = purchasedCurrency * euroToRuble;
                    rubles -= euroPrice;
                    Console.WriteLine($"Вы приобрели {purchasedCurrency} евро за {euroPrice} рублей");
                    break;
            }
            Console.WriteLine($"У вас на счету {dollars} долларов, {euro} евро, {rubles} рублей");
            userInput = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("До свидания");
    }
}

