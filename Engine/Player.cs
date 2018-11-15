using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class Player
    {
        // Declare public player variables that will be displayed on the screen.
        public int currentHealthPoints { get; set; }
        public int maxHealthPoints { get; set; }
        public int gold { get; set; }
        public int experiencePoints { get; set; }
        public int level { get; set; }
    }
}
