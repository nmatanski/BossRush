using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    class InventoryItem
    {
        public Item Details { get; set; }

        public int Quantity { get; set; }

        public string Description { get { return Quantity > 1 ? Details.PluralName : Details.Name; } }

        public InventoryItem(Item details, int quantity)
        {
            Details = details;
            Quantity = quantity;
        }
    }
}
