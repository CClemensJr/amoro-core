using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class Location 
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Item ItemsToEnterHere { get; set; }
        public Quest QuestsHere { get; set; }
        public Monster MonstersHere { get; set; }
        public Location NorthOfHere { get; set; }
        public Location EastOfHere { get; set; }
        public Location SouthOfHere { get; set; }
        public Location WestOfHere { get; set; }

        public Location(int id, string name, string description)
        {
            ID = id;
            Name = name;
            Description = description;

        }
    }

}
