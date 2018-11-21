using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public static class World
    {
        // Lists used to store all game data
        public static readonly List<Item> Items = new List<Item>();
        public static readonly List<Monster> Monster = new List<Monster>();
        public static readonly List<Quest> Quests = new List<Quest>();
        public static readonly List<Location> Locations = new List<Location>();
    }
}
