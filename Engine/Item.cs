using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
   public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PluralName { get; set; }
        public string ItemDetails { get; set; }
       
            public Item(int id,string name,string pluralname,string itemdetails)
            {
            Id = id;
            Name = name;
            PluralName = pluralname;
            ItemDetails = itemdetails;
            }
        }
        
    }
}
