using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Creature
    {
       public int MaxHp { get; set; }
       public int CurHp { get; set; }
      public  int Mp { get; set; }
       public string Name { get; set; }
        public int Id { get; set; }
    }
    public class Player:Creature
    { 
       public int Gold { get; set; }
    }

    public class Enemy:Creature
    {
       
    }
}
