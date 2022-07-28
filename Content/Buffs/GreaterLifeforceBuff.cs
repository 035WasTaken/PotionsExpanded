using Terraria;
using Terraria.ModLoader;
using System;

namespace PotionsExpanded.Content.Buffs
{
    public class GreaterLifeforceBuff : ModBuff
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Greater Lifeforce");
            Description.SetDefault("Increases life by 35%");
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.statLifeMax2 += (int)Math.Round((double)35 / 100 * player.statLifeMax);
        }

        public override void Update(NPC npc, ref int buffIndex)
        {
            npc.lifeMax += (int)Math.Round((double)35 / 100 * npc.lifeMax);
        }
    }
}