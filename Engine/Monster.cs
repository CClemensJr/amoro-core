using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class Monster
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int MaxHealthPoints { get; set; }
        public int CurrentHealthPoints { get; set; }
        public int MaxDamage { get; set; }
        public int ExperienceReward { get; set; }
        public int FinancialReward { get; set; }
    }
}
