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
        public int ExperienceReward { get; set; }
        public int FinancialReward { get; set; }

        public List<QuestCompletionItem> QuestCompletionItems { get; set; }
        public Item ItemReward { get; set; }

        public Quest(int id, string name, string details, int xp, int money, Item item = null)
        {
            ID = id;
            Name = name;
            Details = details;
            ExperienceReward = xp;
            FinancialReward = money;
            ItemReward = item;

            QuestCompletionItems = new List<QuestCompletionItem>();
        }
    }
}
