using System;

using Engine;

namespace UserInterface
{
    public class Amoro
    {
        private Player _player;
        private Monster _currentMonster;

        static void Main(string[] args)
        {
            // Construct class objects
            //Player player = new Player("Leydin", 10, 10, 0, 0, 1);
            //Location location = new Location(1, "Home", "This is your tidy spot in the village of Amoro");
            //Quest quest = new Quest(1, "Do The Dishes", "Every great adventurer has their humble beginnings and you are no different. Your dishes have been piling up for weeks so please get those done as soon as possible so that a monster doesn't spawn from them, ok? I mean, seriously, who let's their dishes go on for so long. Thats disgusting. You should know better.", 10, 10);
            //HealthPotion pot = new HealthPotion(1, "Pot", "Pots", 10);
            //Weapon knife = new Weapon(1, "rusty knife", "rusty knives", 2, 5);
            //Monster mouse = new Monster(1, "A cute little mouse", 1, 1, 2, 5, 5);
            
            // Create an instance of the Amoro class so that Main can make calls to non-static methods
            Amoro a = new Amoro();

            a.initializePlayer();


            // Screen Output

            Console.WriteLine("WELCOME TO AMORO");

            Console.WriteLine($"PLAYER: {a._player.Name}\n" +
                              $"LEVEL:  {a._player.Level}\n" +
                              $"HP:     {a._player.CurrentHealthPoints} / {a._player.MaxHealthPoints}\n" +
                              $"GOLD:   {a._player.Money}\n" +
                              $"XP:     {a._player.ExperiencePoints}\n");

            //Console.WriteLine($"Current Location: {location.Name} - {location.Description}");
            //Console.WriteLine($"Current Quest:    {quest.Name} - {quest.Details}. Reward: {quest.ExperienceReward}xp and {quest.FinancialReward} schmoney");
            //Console.WriteLine($"Current Item:     {pot.Name} that heals for {pot.HealAmount}");
            //Console.WriteLine($"Current Weapon:   {knife.Name}. Damage Dealt: {knife.MinDamage} - {knife.MaxDamage}");
            //Console.WriteLine($"Current Foe:      {mouse.Name}.");

            Console.ReadLine();
        }

        public void initializePlayer()
        {
            _player = new Player("Leydin", 10, 10, 0, 0, 1);
            MoveTo(World.LocationByID(World.LOCATION_ID_HOME));
            _player.Inventory.Add(new InventoryItem(World.ItemByID(World.ITEM_ID_RUSTY_SWORD), 1));
        }


    }
}
