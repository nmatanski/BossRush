using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class LootItem : Item
    {
        public Item Details { get; set; }

        public int DropPercentage { get; set; }

        public bool IsDefaultItem { get; set; }

        public LootItem(int id, string name, string pluralName, string itemDetails, int dropPercentage, bool isDefaultItem, Item details) : base(id, name, pluralName, itemDetails)
        {
            DropPercentage = dropPercentage;
            IsDefaultItem = isDefaultItem;
            Details = details;
        }
    }
}
