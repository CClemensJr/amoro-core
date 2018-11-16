using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class Quest
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
        public int ExperiencePointsReward { get; set; }
        public int GoldReward { get; set; }
    }
}
