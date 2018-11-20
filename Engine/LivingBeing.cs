using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class LivingBeing
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int CurrentHealthPoints { get; set; }
        public int MaxHealthPoints { get; set; }

        public LivingBeing(string name, int currentHP, int maxHP, int id = 0)
        {
            ID = id;
            Name = name;
            CurrentHealthPoints = currentHP;
            MaxHealthPoints = maxHP;
        }
    }
}
