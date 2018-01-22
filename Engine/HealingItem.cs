using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    class HealingItem:Item
    {
        public int AmmountToHeal { get; set; }
        public HealingItem(int id,string name,string pluralname,string itemdetails,int ammounttoheal):base(id,name,pluralname,itemdetails)
        {
            AmmountToHeal = ammounttoheal;
        }
    }
}
