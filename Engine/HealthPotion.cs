using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class HealthPotion: Item
    {
        public int HealAmount { get; set; }

        public HealthPotion(int healAmount) : base(id, name, names)
        {
            HealAmount = healAmount;
        }
    }
}
