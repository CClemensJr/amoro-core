using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public static class World
    {
        // Lists used to store all Item, Monster, Quest, and Location instances
        public static readonly List<Item> Items = new List<Item>();
        public static readonly List<Monster> Monster = new List<Monster>();
        public static readonly List<Quest> Quests = new List<Quest>();
        public static readonly List<Location> Locations = new List<Location>();

        // Item instance ids
        public const int ITEM_ID_RUSTY_SWORD = 1;
        public const int ITEM_ID_RAT_TAIL = 2;
        public const int ITEM_ID_PIECE_OF_FUR = 3;
        public const int ITEM_ID_SNAKE_FANG = 4;
        public const int ITEM_ID_SNAKE_SKIN = 5;
        public const int ITEM_ID_CLUB = 6;
        public const int ITEM_ID_HEALTH_POTION = 7;
        public const int ITEM_ID_SPIDER_FANG = 8;
        public const int ITEM_ID_SPIDER_SILK = 9;
        public const int ITEM_ID_ADVENTURER_PASS = 10;

        // Monster instance ids
        public const int MONSTER_ID_RAT = 1;
        public const int MONSTER_ID_SNAKE = 2;
        public const int MONSTER_ID_GIANT_SPIDER = 3;

        // Quest instance ids
        public const int QUEST_ID_CLEAR_ALCHEMIST_GARDEN = 1;
        public const int QUEST_ID_CLEAR_FARMERS_FIELD = 2;

        // Location instance ids
        public const int LOCATION_ID_HOME = 1;
        public const int LOCATION_ID_TOWN_SQUARE = 2;
        public const int LOCATION_ID_GUARD_POST = 3;
        public const int LOCATION_ID_ALCHEMIST_HUT = 4;
        public const int LOCATION_ID_ALCHEMISTS_GARDEN = 5;
        public const int LOCATION_ID_FARMHOUSE = 6;
        public const int LOCATION_ID_FARM_FIELD = 7;
        public const int LOCATION_ID_BRIDGE = 8;
        public const int LOCATION_ID_SPIDER_FIELD = 9;

        
        static World()
        {
            PopulateItems();
            PopulateMonsters();
            PopulateQuests();
            PopulateLocations();
        }

        private static void PopulateItems()
        {
            // Add each item to the Items list. Seems really inefficient, will likely want to store the item info in an array then use a loop to add each item.
            Items.Add(new Weapon(ITEM_ID_RUSTY_SWORD, "rusty sword", "rusty swords", 1, 5));
            Items.Add(new Item(ITEM_ID_RAT_TAIL, "rat tail", "rat tails"));
            Items.Add(new Item(ITEM_ID_PIECE_OF_FUR, "piece of fur", "pieces of fur"));
            Items.Add(new Item(ITEM_ID_SNAKE_FANG, "snake fang", "snake fangs"));
            Items.Add(new Item(ITEM_ID_SNAKE_SKIN, "snake skin", "snake skins"));
            Items.Add(new Weapon(ITEM_ID_CLUB, "club", "clubs", 3, 10));
            Items.Add(new HealthPotion(ITEM_ID_HEALTH_POTION, "pot", "pots", 5));
            Items.Add(new Item(ITEM_ID_SPIDER_FANG, "spider fang", "spider fangs"));
            Items.Add(new Item(ITEM_ID_SPIDER_SILK, "spider silk", "spider silks"));
            Items.Add(new Item(ITEM_ID_ADVENTURER_PASS, "Adventurer Pass", "Adventurer Passes"));

        }

        private static void PopulateMonsters()
        {
            Monster rat = new Monster(MONSTER_ID_RAT, "Rat", 5, 3, 10, 3, 3);
            rat.LootTable.Add(new LootItem(ItemByID(ITEM_ID_RAT_TAIL), 75, false));
            rat.LootTable.Add(new LootItem(ItemByID(ITEM_ID_PIECE_OF_FUR), 75, true));

            Monster snake = new Monster(MONSTER_ID_SNAKE, "Snake", 5, 3, 10, 3, 3);
            snake.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SNAKE_FANG), 75, false));
            snake.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SNAKE_SKIN), 75, true));

            Monster giantSpider = new Monster(MONSTER_ID_GIANT_SPIDER, "Giant spider", 20, 5, 40, 10, 10);
            giantSpider.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SPIDER_FANG), 75, true));
            giantSpider.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SPIDER_SILK), 25, false));

            Monsters.Add(rat);
            Monsters.Add(snake);
            Monsters.Add(giantSpider);

        }

        private static void PopulateQuests()
        {

        }

        private static void PopulateLocations()
        {

        }

    }
}
