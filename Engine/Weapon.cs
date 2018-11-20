using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class Weapon: Item
    {
        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }

        public Weapon(int id, string name, string names, int minDmg, int maxDmg) : base(id, name, names)
        {
            MinDamage = minDmg;
            MaxDamage = maxDmg;
        }
    }
}
