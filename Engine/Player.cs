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
    }
}
