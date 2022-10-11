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
        int poisonDuration = 3;
        int arrowDamage = 50;
        double criticalDamage = 0.3;
        int counterForPoison = 0;
        int counterForStone = 0;
        const int shield = 1;
        const int arrow = 2;
        const int damage = 3;
        const int stone = 4;

        while(playerHealth > 0 & bossHealth > 0 )
        {
            Console.WriteLine($"Ваше здоровье: {playerHealth}. Здоровье босса: {bossHealth}");
            Console.WriteLine("Выберите один из ваших скилов:");
            Console.WriteLine($"{shield} - Энергетический щит. Поглощает весь урон от следующего удара врага, восстанавливает {regeneration} единиц здоровья");
            Console.WriteLine($"{arrow} - Ядовитая стрела. Наносит {arrowDamage} единиц урона. Яд действет {poisonDuration} следующих хода и наносит {poisonDamage} единиц урона");
            Console.WriteLine($"{damage} - Критический урон. Наносит урон в размере {criticalDamage} от здоровья врага");
            Console.WriteLine($"{stone} - Окаменение. Превращает врага в камень, если на него действеут яд");
            userInput = Convert.ToInt32(Console.ReadLine());

            if (userInput == shield)
            {
                playerHealth += regeneration;
            }
            else if (userInput == arrow)
            {
                counterForPoison = poisonDuration;
                bossHealth -= arrowDamage;
            }
            else if(userInput == damage)
            {
                bossHealth -= Convert.ToInt32(bossHealth * criticalDamage);
            }
            else if(userInput == stone)
            {
                if(counterForPoison > 0)
                {
                    counterForStone = counterForPoison;
                }
            }

            if (counterForPoison > 0)
            {
                bossHealth -= poisonDamage;

                if(counterForStone > 0)
                {
                    bossDamage = 0;
                    counterForStone = counterForPoison;
                    counterForStone -= 1;
                }

                counterForPoison -= 1;
            }

            if (userInput != shield)
            {
                playerHealth -= bossDamage;
            }
            
            bossDamage = 50;
        }

        if (bossHealth <= 0 & playerHealth <= 0)
        {
            Console.WriteLine("Ничья");
        }

        else if (bossHealth < 1)
        {
            Console.WriteLine("Вы победили!");
        }

        else
        {
            Console.WriteLine("Вы проиграли");
        }
    }
}

