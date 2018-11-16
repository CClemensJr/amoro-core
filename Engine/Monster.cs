using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class Monster: LivingBeing
    {
        public int ID { get; set; }
        public int MaxDamage { get; set; }
        public int ExperienceReward { get; set; }
        public int FinancialReward { get; set; }
    }
}
