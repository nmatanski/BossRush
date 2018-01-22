using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Player : Creature
    {
        public int Gold { get; set; }
        public Player(int id, string name, int maxHP, int currentHP,int gold) : base(id, name, maxHP, currentHP)
        {

            Gold = gold;
        }

       
    }
}
