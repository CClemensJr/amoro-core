using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class Player
    {
        // Declare public player attributes that will be displayed on the screen.
        public int CurrentHealthPoints { get; set; }
        public int ExperiencePoints { get; set; }
        public int Gold { get; set; }
        public int Level { get; set; }
        public int MaxHealthPoints { get; set; }
        public string PlayerName { get; set; }
    }
}
