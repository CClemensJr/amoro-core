using System;
using Engine;

namespace UserInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            // Construct class objects
            Player player = new Player("Leydin", 10, 10, 0, 0, 1);
            Location location = new Location(1, "Home", "This is your tidy spot in the village of Amoro");
            Quest quest = new Quest(1, "Do The Dishes", "Every great adventurer has their humble beginnings and you are no different. Your dishes have been piling up for weeks so please get those done as soon as possible so that a monster doesn't spawn from them, ok? I mean, seriously, who let's their dishes go on for so long. Thats disgusting. You should know better.", 10, 10);
            HealthPotion pot = new HealthPotion(1, "Pot", "Pots", 10);
            Weapon knife = new Weapon(1, "rusty knife", "rusty knives", 2, 5);
            Monster mouse = new Monster(1, "A cute little mouse", 1, 1, 2, 5, 5);


            // Screen Output

            Console.WriteLine("WELCOME TO AMORO");

            Console.WriteLine($"PLAYER: {player.Name}\n" +
                              $"LEVEL:  {player.Level}\n" +
                              $"HP:     {player.CurrentHealthPoints} / {player.MaxHealthPoints}\n" +
                              $"GOLD:   {player.Money}\n" +
                              $"XP:     {player.ExperiencePoints}\n");

            Console.WriteLine($"Current Location: {location.Name} - {location.Description}");
            Console.WriteLine($"Current Quest:    {quest.Name} - {quest.Details}. Reward: {quest.ExperienceReward}xp and {quest.FinancialReward} schmoney");
            Console.WriteLine($"Current Item:     {pot.Name} that heals for {pot.HealAmount}");
            Console.WriteLine($"Current Weapon:   {knife.Name}. Damage Dealt: {knife.MinDamage} - {knife.MaxDamage}");
            Console.WriteLine($"Current Foe:      {mouse.Name}.");

            Console.ReadLine();
        }

    }
}
