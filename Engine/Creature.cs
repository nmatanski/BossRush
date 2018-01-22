using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Creature
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public int MaxHp { get; set; }

        public int CurHp { get; set; }

        public int Mp { get; set; }


        public Creature (int id, string name, int maxHP, int currentHP)
        {
            Id = id;
            Name = name;
            MaxHp = maxHP;
            CurHp = currentHP;
        }


    }
}
