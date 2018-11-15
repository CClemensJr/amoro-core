using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class Player
    {
        // Declare public player variables that will be displayed on the screen.
        public int CurrentHP { get; set; }
        public int MaxHP { get; set; }
        public int Gold { get; set; }
        public int XP { get; set; }
        public int Level { get; set; }
    }
}
