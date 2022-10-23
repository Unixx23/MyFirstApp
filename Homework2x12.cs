using System;

internal class Homework2x12
{
    static void Main(string[] args)
    {
        const int Shield = 1;
        const int Arrow = 2;
        const int Damage = 3;
        const int Stone = 4;
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

        while (playerHealth > 0 & bossHealth > 0)
        {
            Console.WriteLine($"Ваше здоровье: {playerHealth}. Здоровье босса: {bossHealth}");
            Console.WriteLine("Выберите один из ваших скилов:");
            Console.WriteLine($"{Shield} - Энергетический щит. Поглощает весь урон от следующего удара врага, восстанавливает {regeneration} единиц здоровья");
            Console.WriteLine($"{Arrow} - Ядовитая стрела. Наносит {arrowDamage} единиц урона. Яд действет {poisonDuration} следующих хода и наносит {poisonDamage} единиц урона");
            Console.WriteLine($"{Damage} - Критический урон. Наносит урон в размере {criticalDamage} от здоровья врага");
            Console.WriteLine($"{Stone} - Окаменение. Превращает врага в камень, если на него действеут яд");
            userInput = Convert.ToInt32(Console.ReadLine());

            if (userInput == Shield)
            {
                playerHealth += regeneration;
            }
            else if (userInput == Arrow)
            {
                counterForPoison = poisonDuration;
                bossHealth -= arrowDamage;
                playerHealth -= bossDamage;
            }
            else if (userInput == Damage)
            {
                bossHealth -= Convert.ToInt32(bossHealth * criticalDamage);
                playerHealth -= bossDamage;
            }
            else if (userInput == Stone)
            {
                if (counterForPoison > 0)
                {
                    counterForStone = counterForPoison;
                }
                else
                {
                    playerHealth -= bossDamage;
                }
            }

            if (counterForPoison > 0)
            {
                bossHealth -= poisonDamage;

                if (counterForStone > 0)
                {
                    counterForStone = counterForPoison;
                    counterForStone -= 1;
                }

                counterForPoison -= 1;
            }
        }

        if (bossHealth <= 0 && playerHealth <= 0)
        {
            Console.WriteLine("Ничья");
        }
        else if (bossHealth <= 0)
        {
            Console.WriteLine("Вы победили!");
        }
        else if(playerHealth <= 0)
        {
            Console.WriteLine("Вы проиграли");
        }
    }
}
