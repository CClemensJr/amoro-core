using System;
using Engine;

namespace UserInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            //PLAYER OBJECT CONSTRUCTOR
            // Create an instance of the Player class
            Player player = new Player();

            // Set the player attributes
            player.CurrentHealthPoints = 10;
            player.ExperiencePoints = 0;
            player.Money = 0;
            player.Level = 1;
            player.MaxHealthPoints = 10;
            player.Name = "Leydin";


            // Construct class objects
            Location location = new Location(1, "Home", "This is your tidy spot in the village of Amoro");
            Quest quest = new Quest(1, "Do The Dishes", "Every great adventurer has their humble beginnings and you are no different. Your dishes have been piling up for weeks so please get those done as soon as possible so that a monster doesn't spawn from them, ok? I mean, seriously, who let's their dishes go on for so long. Thats disgusting. You should know better.", 10, 10);

            Console.WriteLine("WELCOME TO AMORO");

            Console.WriteLine($"PLAYER: {player.Name}\n" +
                              $"LEVEL:  {player.Level}\n" +
                              $"HP:     {player.CurrentHealthPoints} / {player.MaxHealthPoints}\n" +
                              $"GOLD:   {player.Money}\n" +
                              $"XP:     {player.ExperiencePoints}\n");

            Console.WriteLine($"Current Location: {location.Name} - {location.Description}");
            Console.WriteLine($"Current Quest:    {quest.Name} - {quest.Details}. Reward: {quest.ExperienceReward}xp and {quest.FinancialReward} schmoney");


            Console.ReadLine();
        }

    }
}
