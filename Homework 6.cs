using System;

internal class Program
{
    static void Main(string[] args)
    {
        int crystals = 0;
        int crystalPrice = 5;
        Console.WriteLine("Добро пожаловать в магазин!");
        Console.WriteLine("Сколько у вас золота?");
        int gold = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Сегодня в продаже кристаллы всего по {crystalPrice} золота!");
        Console.WriteLine("Сколько кристаллов желаете приобрести?");
        int purchasedCrystals = Convert.ToInt32(Console.ReadLine());
        int costOfCrystals = purchasedCrystals * crystalPrice;
        gold = gold - costOfCrystals;
        crystals = crystals + purchasedCrystals;
        Console.WriteLine($"Вы приобрели {purchasedCrystals} за {costOfCrystals} золота");
        Console.WriteLine($"У вас на счету {crystals} кристаллов и {gold} золота");
    }
    
}
