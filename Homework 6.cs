using System;

internal class Program
{
    static void Main(string[] args)
    {
         int crystals = 0;
         int crystalPrice = 5;
         Console.WriteLine("Добро пожаловать в магазин!");
         Console.WriteLine("Сколько у вас золота?");
         int gold = Convert.ToInt32(Console.Deadline());
         Console.WriteLine($"Сегодня в продаже кристаллы всего по {crystalPrice} золота!");
         Console.WriteLine("Сколько кристаллов желаете приобрести?");
         int purchasedCrystals = Convert.ToInt32(Console.ReadLine());
         int goldPay = purchased crystals * crystalPrice;
         gold = gold - goldPay;
         crystals = crystals + purchasedCrystals;
         Console.WriteLine($"Вы приобрели {purchasedCrystals}
         за {goldPay} золота");
         Console.WriteLine($"У вас на счету {crystals} кристаллов и {gold} золота");
    }
}
