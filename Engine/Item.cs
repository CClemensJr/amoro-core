﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class Item
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string PluralName { get; set; }

        public Item(int id, string name, string names)
        {
            ID = id;
            Name = name;
            PluralName = names;
        }
    }
}
