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

        public int CurrentHP { get; set; }

        public int MaxHP { get; set; }

        public int ManaPoints { get; set; }


        public Creature(int id, string name, int maxHP, int currentHP)
        {
            Id = id;
            Name = name;
            MaxHP = maxHP;
            CurrentHP = currentHP;
        }


    }
}
