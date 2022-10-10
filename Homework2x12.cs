using System;

internal class Homework2x12
{
    static void Main(string[] args)
    {
        int bossHealth = 1000;
        int playerHealth = 150;
        int bossDamage = 50;
        int userInput;
        int regeneration = 50;
        int poisonDamage = 100;
        int arrowDamage = 50;
        double criticalDamage = 0.3;
        int counterForPoison = 0;
        int counterForStone = 0;

        while(playerHealth > 0 & bossHealth > 0 )
        {
            Console.WriteLine($"Ваше здоровье: {playerHealth}. Здоровье босса: {bossHealth}");
            Console.WriteLine("Выберите один из ваших скилов:");
            Console.WriteLine($"1 - Энергетический щит. Поглощает весь урон от следующего удара врага, восстанавливает {regeneration} единиц здоровья");
            Console.WriteLine($"2 - Ядовитая стрела. Наносит {arrowDamage} единиц урона. Яд действет 3 следующих хода и наносит 100 единиц урона");
            Console.WriteLine($"3 - Критический урон. Наносит урон в размере {criticalDamage} от здоровья врага");
            Console.WriteLine("4 - Окаменение. Превращает врага в камень, если на него действеут яд");
            userInput = Convert.ToInt32(Console.ReadLine());

            if (userInput == 1)
            {
                playerHealth += bossDamage;
                playerHealth += regeneration;
            }
            else if (userInput == 2)
            {
                counterForPoison = 3;
                bossHealth -= arrowDamage;
            }
            else if(userInput == 3)
            {
                bossHealth -= Convert.ToInt32(bossHealth * criticalDamage);
            }
            else if(userInput == 4)
            {
                if(counterForPoison > 0)
                {
                    counterForStone = 1;
                }
            }

            if (counterForPoison > 0)
            {
                bossHealth -= poisonDamage;

                if(counterForStone == 1)
                {
                    bossDamage = 0;
                }

                counterForPoison -= 1;

                if(counterForPoison == 0)
                {
                    counterForStone = 0;
                }
            }
            
            playerHealth -= bossDamage;
            bossDamage = 50;

            if(bossHealth<=0 & playerHealth <= 0) 
            {
                Console.WriteLine("Ничья");
                break;
            }
        }

        if(bossHealth < 1)
        {
            Console.WriteLine("Вы победили!");
        }

        if(playerHealth < 1)
        {
            Console.WriteLine("Вы проиграли");
        }
    }
}

