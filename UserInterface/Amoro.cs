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
            createSection("WELCOME TO AMORO", 5, 1);
            initializeGame();
            showPlayerDetails();
            showPlayerInventory();
        }

        public void createSection(string text, int rows, int spacing)
        {
            int screenWidth = Console.WindowWidth;
            int centerText = ((screenWidth) / 2) + ((text.Length) / 2);
            string border = " ";

            for (int i = 0; i < (screenWidth - 2); i++)
            {
                border += "*";
            }

            for (int i = 0; i < rows; i++)
            {
                if (i == 0 || i == rows - 1)
                {
                    Console.WriteLine(String.Format("{0," + (screenWidth - 2) + "}", border));
                }
                else if (i == (rows / 2))
                {
                    Console.WriteLine(String.Format("{0," + centerText + "}", text));
                }
                else
                {
                    Console.WriteLine(String.Format("{0,1} {1," + (screenWidth - 3) + "}", "*", "*"));
                }

            }
            
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
