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
            // Create an instance of the Amoro class so that Main can make calls to non-static methods
            Amoro a = new Amoro();

            // Set up the console
            a.userInterface();

            Console.ReadLine();
        }

        public void userInterface()
        {
            Console.WriteLine("**************************************************************\n" +
                              "****                                                      ****\n" +
                              "****                     WELCOME TO AMORO                 ****\n" +
                              "****                                                      ****\n" +
                              "**************************************************************\n");

            initializeGame();
            showPlayerDetails();
            showPlayerInventory();
        }

        public void createSections(string text, int rows, int spaceAbove, int spaceBelow)
        {

        }

        public void initializeGame()
        {
            _player = new Player("Leydin", World.LocationByID(World.LOCATION_ID_HOME), 10, 10, 0, 0, 1);
            _player.Inventory.Add(new InventoryItem(World.ItemByID(World.ITEM_ID_RUSTY_SWORD), 1));
        }

        public void showPlayerDetails()
        {
            Console.WriteLine( "**************************************************************\n" +
                              $"**** LOCATION: {_player.CurrentLocation.Name} - {_player.CurrentLocation.Description}                                 ****\n" +
                               "**************************************************************\n");

            Console.WriteLine($"LOCATION:   {_player.CurrentLocation.Name}\n" +
                              $"PLAYER:     {_player.Name}\n" +
                              $"LEVEL:      {_player.Level}\n" +
                              $"HP:         {_player.CurrentHealthPoints} / {_player.MaxHealthPoints}\n" +
                              $"SCHMONEY:   {_player.Money}\n" +
                              $"XP:         {_player.ExperiencePoints}\n");
        }

        public void showPlayerInventory()
        {
            Console.WriteLine("Inventory");

            foreach(InventoryItem item in _player.Inventory)
            {
                Console.WriteLine(item.Details.Name);
            }
        }

        public void MoveTo(Location newLocation)
        {
            _player.CurrentLocation = newLocation;
        }

    }
}
