using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PotionsExpanded.Content.Buffs
{
    public class MarshPotionBuff : ModBuff
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Marsh's Potion");
            Description.SetDefault("Power courses through you...");
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.manaCost = 0f;
        }
    }
}