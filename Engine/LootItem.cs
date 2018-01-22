using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class LootItem
    {
        public Item Details { get; set; }

        public int DropPercentage { get; set; }

        public bool IsDefaultItem { get; set; }

        public LootItem(Item item, int dropPercentage, bool isDefaultItem)
        {
            Details = item;
            DropPercentage = dropPercentage;
            IsDefaultItem = isDefaultItem;
        }
    }
}
