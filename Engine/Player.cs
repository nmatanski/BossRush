using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Player : Creature
    {
        public string UserId { get; set; }

        public int Gold { get; set; }

        public int Xp { get; private set; }

        public int Level { get { return (int)Math.Floor(Xp / 100.0) + 1; } }

        public List<InventoryItem> Inventory { get; set; }

        public Player(int id, string name, int maxHP, int currentHP, int gold, int xp) : base(id, name, maxHP, currentHP)
        {
            Xp = xp;
            Gold = gold;

            Inventory = new List<InventoryItem>();
        }

        public static Player CreateDefaultPlayer(string userId)
        {
            Player player = new Player(1, "Gosho", 100, 100, 50, 0);
            player.UserId = userId;
            player.Inventory.Add(new InventoryItem(World.ItemByID(World.ITEM_ID_BROKEN_SWORD), 1));
            return player;
        }


    }
}
