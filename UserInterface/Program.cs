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

            // Set the player variables
            player.CurrentHealthPoints = 10;
            player.MaxHealthPoints = 10;
            player.Gold = 0;
            player.ExperiencePoints = 0;
            player.Level = 1;


            Console.WriteLine("Hello World!");

            Console.ReadLine();
        }
    }
}
