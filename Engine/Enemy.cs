using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Enemy : Creature
    {
        public int MinimumDamage { get; set; }

        public int MaximumDamage { get; set; }

        public int RewardXP { get; set; }

        public int RewardGold { get; set; }

        public List<LootItem> LootTable { get; set; }

        public Enemy(int id, string name, int maxHP, int currentHP, int minDamage, int maxDamage, int rewardGold, int rewardXP) : base(id, name, maxHP, currentHP)
        {
            Id = id;
            Name = name;
            MinimumDamage = minDamage;
            MaximumDamage = maxDamage;
            RewardXP = rewardXP;
            RewardGold = rewardGold;

            LootTable = new List<LootItem>();

        }
    }
}
