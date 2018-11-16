using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class Weapon
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string PluralName { get; set; }
        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }
    }
}
