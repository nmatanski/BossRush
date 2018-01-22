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

        public int Xp { get; private set; }

        public int Level { get { return (int)Math.Floor(Xp / 100.0) + 1; } }

        public Player(int id, string name, int maxHP, int currentHP, int gold, int xp) : base(id, name, maxHP, currentHP)
        {
            Xp = xp;
            Gold = gold;
        }


    }
}
