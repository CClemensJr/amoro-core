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
            player.Gold = 0;
            player.Level = 1;
            player.MaxHealthPoints = 10;
            player.Name = "Leydin";



            Console.WriteLine("WELCOME TO AMORO");

            Console.WriteLine($"PLAYER: {player.Name}\n" +
                              $"LEVEL:  {player.Level}\n" +
                              $"HP:     {player.CurrentHealthPoints} / {player.MaxHealthPoints}\n" +
                              $"GOLD:   {player.Gold}\n" +
                              $"XP:     {player.ExperiencePoints}\n");

            Console.ReadLine();
        }
    }
}
