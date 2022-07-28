using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PotionsExpanded.Content.Buffs
{
    public class SpiritDanceBuff : ModBuff
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Spirit Dance");
            Description.SetDefault("Your spirit is overjoyed");
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.statManaMax2 += (int)Math.Round((double)25 / 100 * player.statManaMax);
            player.statDefense += (int)Math.Round((double)5 / 100 * player.statDefense);
            player.GetAttackSpeed(DamageClass.Magic) *= 1.15f;
        }
    }
}