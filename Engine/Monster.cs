using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class Monster: LivingBeing
    {
        public int MaxDamage { get; set; }
        public int ExperienceReward { get; set; }
        public int FinancialReward { get; set; }

        public List<LootItem> LootTable { get; set; }

        public Monster(int id, string name, int currentHP, int maxHP, int maxDmg, int xp, int money) : base(name, currentHP, maxHP, id)
        {
            MaxDamage = maxDmg;
            ExperienceReward = xp;
            FinancialReward = money;

            LootTable = new List<LootItem>();
        }
    }
}
