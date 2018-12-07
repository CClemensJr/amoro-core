using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class Player: LivingBeing
    {
        public int ExperiencePoints { get; set; }
        public int Money { get; set; }
        public int Level { get; set; }

        public Location CurrentLocation { get; set; }

        public List<InventoryItem> Inventory { get; set; }
        public List<PlayerQuest> Quests { get; set; }


        public Player(string name, int currentHP, int maxHP, int xp, int money, int lvl) : base(name, currentHP, maxHP)
        {
            ExperiencePoints = xp;
            Money = money;
            Level = lvl;

            Inventory = new List<InventoryItem>();
            Quests = new List<PlayerQuest>();
        }
    }
}
