using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
   public class LootItem:Item
    {
        public Item Details { get; set; }
       public int DropPercentage { get; set; }
        public bool IsDefaultItem { get; set; }

        public LootItem(int id,string name,string pluralname,string itemdetails,int droppercentage,bool isdefaultitem,Item details):base(id,name,pluralname,itemdetails)
        {
            DropPercentage = droppercentage;
            IsDefaultItem = isdefaultitem;
            Details = details;
        }
    }
}
