using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class HealthPotion: Item
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string PluralName { get; set; }
        public int HealAmount { get; set; }
    }
}
