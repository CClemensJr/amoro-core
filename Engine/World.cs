﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public static class World
    {
        // Lists used to store all Item, Monster, Quest, and Location instances
        public static readonly List<Item> Items = new List<Item>();
        public static readonly List<Monster> Monsters = new List<Monster>();
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
        public const int LOCATION_ID_ALCHEMISTS_HUT = 4;
        public const int LOCATION_ID_ALCHEMISTS_GARDEN = 5;
        public const int LOCATION_ID_FARMHOUSE = 6;
        public const int LOCATION_ID_FARM_FIELD = 7;
        public const int LOCATION_ID_BRIDGE = 8;
        public const int LOCATION_ID_SPIDER_FIELD = 9;

        // Construct the world objects
        static World()
        {
            PopulateItems();
            PopulateMonsters();
            PopulateQuests();
            PopulateLocations();
        }

        // Construct Items
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

        // Construct Monsters
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

        // Construct Quests
        private static void PopulateQuests()
        {
            Quest clearAlchemistsGarden = new Quest(QUEST_ID_CLEAR_ALCHEMIST_GARDEN,
                    "Clear the alchemist's garden.",
                    "Kill rats in the alchemist's garden and bring back 3 rat tails. You will receive a healing potion and 10 shmoney.",
                    20,
                    10
                );

            clearAlchemistsGarden.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_RAT_TAIL), 3));
            clearAlchemistsGarden.ItemReward = ItemByID(ITEM_ID_HEALTH_POTION);

            Quest clearFarmersField = new Quest(
                    QUEST_ID_CLEAR_FARMERS_FIELD,
                    "Clear the farmer's field",
                    "Kill snakes in the farmer's field and bring back 3 snake fangs. You will receive an Adventurer Pass and 20 shmoney",
                    20,
                    20
                );

            clearFarmersField.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_SNAKE_FANG), 3));
            clearFarmersField.ItemReward = ItemByID(ITEM_ID_ADVENTURER_PASS);

            Quests.Add(clearAlchemistsGarden);
            Quests.Add(clearFarmersField);
;        }

        // Construct Locations
        private static void PopulateLocations()
        {
            Location home = new Location(LOCATION_ID_HOME, "Home", "This is your house. It smells weird");

            Location townSquare = new Location(LOCATION_ID_TOWN_SQUARE, "Town square", "This is where everyone comes to do their things. There are vendors, a bulletin board, and a fountain.");

            // alchemistHut
            Location alchemistsHut = new Location(LOCATION_ID_ALCHEMISTS_HUT, "Alchemist's Hut", "This is where you can buy your potions and such.");

            // alchemistsGarden
            Location alchemistsGarden = new Location(LOCATION_ID_ALCHEMISTS_GARDEN, "Alchemist's Garden", "The alchemist plants and harvests his herbs here.");

            // farmhouse
            Location farmhouse = new Location(LOCATION_ID_FARMHOUSE, "Farm house", "A farmhouse on the edge of town");

            // farmersField
            Location farmersField = new Location(LOCATION_ID_FARM_FIELD, "Farmer's field", "There a bunch of plants and animals here.");

            // guardPost
            Location guardPost = new Location(LOCATION_ID_GUARD_POST, "Guard post", "The town guard post keeps an eye on the forest but is rarely manned these days.");

            // bridge
            Location bridge = new Location(LOCATION_ID_BRIDGE, "The bridge", "The bridge leads out of town and into the forest.");

            // spiderField
            Location spiderField = new Location(LOCATION_ID_SPIDER_FIELD, "Spider field", "Supposedly full of giant spiders, most believe this to be a wive's tale yet no one wants to go out for themselves.");


            // Link the locations together by setting the directional locations
            home.SouthOfHere = townSquare;

            townSquare.NorthOfHere = home;
            townSquare.EastOfHere = guardPost;
            townSquare.SouthOfHere = farmhouse;
            townSquare.WestOfHere = alchemistsHut;

            alchemistsHut.EastOfHere = townSquare;
            alchemistsHut.WestOfHere = alchemistsGarden;

            farmhouse.NorthOfHere = townSquare;
            farmhouse.SouthOfHere = farmersField;

            guardPost.WestOfHere = townSquare;
            guardPost.EastOfHere = bridge;

            bridge.WestOfHere = guardPost;
            bridge.EastOfHere = spiderField;

            spiderField.WestOfHere = bridge;


            // Add the locations to the static list.
            Locations.Add(home);
            Locations.Add(townSquare);
            Locations.Add(guardPost);
            Locations.Add(alchemistsHut);
            Locations.Add(alchemistsGarden);
            Locations.Add(farmhouse);
            Locations.Add(farmersField);
            Locations.Add(bridge);
            Locations.Add(spiderField);

        }

        public static Item ItemByID(int id)
        {
            foreach(Item item in Items)
            {
                if (item.ID == id) return item;
            }

            return null;
        }

        public static Monster MonsterByID(int id)
        {
            foreach(Monster monster in Monsters)
            {
                if (monster.ID == id) return monster;
            }

            return null;
        }

        public static Quest QuestByID(int id)
        {
            foreach(Quest quest in Quests)
            {
                if (quest.ID == id) return quest;
            }

            return null;
        }

        public static Location LocationByID(int id)
        {
            foreach(Location location in Locations)
            {
                if (location.ID == id) return location;
            }

            return null;
        }
    }
}
