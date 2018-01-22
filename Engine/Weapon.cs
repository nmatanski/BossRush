using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Weapon : Item
    {
        public int MinDmg { get; set; }

        public int MaxDmg { get; set; }

        public Weapon(int id, string name, string pluralName, string itemDetails, int minDmg, int maxDmg) : base(id, name, pluralName, itemDetails)
        {
            MinDmg = minDmg;
            MaxDmg = maxDmg;
        }
    }
}
