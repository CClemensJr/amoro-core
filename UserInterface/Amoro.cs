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

            // Create the world of Amoro
            a.initializeGame();

            // Render in console window
            a.userInterface();

            // Handle input from the player
            a.acceptPlayerInput();
        }


        //
        //  GAME SETUP FUNCTIONS
        //
        public void initializeGame()
        {
            _player = new Player("Leydin", World.LocationByID(World.LOCATION_ID_HOME), 10, 10, 0, 0, 1);
            _player.Inventory.Add(new InventoryItem(World.ItemByID(World.ITEM_ID_RUSTY_SWORD), 1));
        }



        //
        // HELPER FUNCTIONS
        //
        public void createSection(string text, int rows)
        {
            int screenWidth = Console.WindowWidth;
            int centerText = ((screenWidth) / 2) + ((text.Length) / 2);
            string borderString = " ";
            string borderType = "-";

            for (int i = 0; i < (screenWidth - 2); i++)
            {
                borderString += borderType;
            }

            for (int i = 0; i < rows; i++)
            {
                if (i == 0 || i == rows - 1)
                {
                    Console.WriteLine(String.Format("{0," + (screenWidth - 2) + "}", borderString));
                }
                else if (i == (rows / 2))
                {
                    Console.WriteLine(String.Format("{0," + centerText + "}", text));
                }
                else
                {
                    Console.WriteLine(String.Format("{0,1} {1," + (screenWidth - 3) + "}", borderType, borderType));
                }

            }
            
        }



        //
        // USER INTERFACE FUNCTIONS
        //
        public void userInterface()
        {
            createSection("WELCOME TO AMORO", 5);
            showPlayerDetails();
            showPlayerInventory();
        }

        public void showPlayerDetails()
        {
            createSection($"LOCATION: {_player.CurrentLocation.Name} - {_player.CurrentLocation.Description}", 3);

            createSection("", 1);
            Console.WriteLine($"LOCATION:   {_player.CurrentLocation.Name} - {_player.CurrentLocation.Description}\n" +
                              $"PLAYER:     {_player.Name}\n" +
                              $"LEVEL:      {_player.Level}\n" +
                              $"HP:         {_player.CurrentHealthPoints} / {_player.MaxHealthPoints}\n" +
                              $"XP:         {_player.ExperiencePoints}");
            createSection("", 1);
        }

        public void showPlayerInventory()
        {
            createSection("", 1);
            Console.WriteLine("INVENTORY");
            Console.WriteLine($"{_player.Money} schmoney");

            foreach(InventoryItem item in _player.Inventory)
            {
                Console.WriteLine(item.Details.Name);
            }

            createSection("", 1);
        }



        //
        // USER INPUT
        //
        public void acceptPlayerInput()
        {

            string input = Console.ReadLine();

            while (input != "QUIT")
            {
                Console.WriteLine("Please type QUIT to quit the game.");

                input = Console.ReadLine();
            }

        }



        //
        // GAMEPLAY FUNCTIONS
        //
        public void MoveTo(Location newLocation)
        {
            // If the new location requires items to enter
            if (newLocation.ItemsToEnterHere != null)
            {
                // Check if the player has the items in the inventory
                bool playerHasRequiredItems = false;

                foreach(InventoryItem item in _player.Inventory)
                {
                    if (item.Details.ID == newLocation.ItemsToEnterHere.ID)
                    {
                        // If item is found exit the loop
                        playerHasRequiredItems = true;

                        break;
                    }
                }

                // If the player doesn't have the items
                if (!playerHasRequiredItems)
                {
                    Console.WriteLine($"You must have a {newLocation.ItemsToEnterHere.Name} to enter this location. {Environment.NewLine}");
                }


            }

            _player.CurrentLocation = newLocation;
        }

    }
}
