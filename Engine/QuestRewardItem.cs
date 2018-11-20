using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class QuestRewardItem
    {
        public Item Details { get; set; }
        public int Quantity { get; set; }

        public QuestRewardItem (Item details, int quantity)
        {
            Details = details;
            Quantity = quantity;
        }
    }
}
