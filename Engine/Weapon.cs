using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Weapon:Item
    {
        public int minDmg { get; set; }
        public int maxDmg { get; set; }

        public Weapon(int id,string name,string pluralname,int mindmg,int maxdmg):base(id,name,pluralname)
        { 
            minDmg = mindmg;
            maxDmg = maxdmg;
            

        }
    }
}
