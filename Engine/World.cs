using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public static class World
    {
        public static List<Item> Items { get; } = new List<Item>();
        public static List<Enemy> Enemies { get; } = new List<Enemy>();
        public static List<Player> Players { get; } = new List<Player>();

        //Weapons
        public const int ITEM_ID_BROKEN_SWORD = 1;
        public const int ITEM_ID_WOODEN_SWORD = 2;
        public const int ITEM_ID_SCIMITAR = 3;
        public const int ITEM_ID_DEMOLISHER = 4;


        //Enemies
        public const int ENEMY_ID_CACTI = 2001;
        public const int ENEMY_ID_WOLF = 2002;
        public const int ENEMY_ID_LOW_MAN = 2003;
        public const int ENEMY_ID_TYPE_THREE = 2004;


      private static void World()
        {
            PopulateItems();
            PopulateEnemies();
        }

       private static void PopulateItems
            {
            Items.Add(new Weapon(ITEM_ID_BROKEN_SWORD,"Broken sword","Broken swords",0,5));
            }
    }
}
