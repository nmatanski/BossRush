using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class HealingItem : Item
    {
        public int AmountToHeal { get; set; }

        public HealingItem(int id, string name, string pluralName, string itemDetails, int ammountToHeal) : base(id, name, pluralName, itemDetails)
        {
            AmountToHeal = ammountToHeal;
        }
    }
}
