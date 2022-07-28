using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using PotionsExpanded.Content.Items.Potions;

namespace PotionsExpanded.Common.CustomNPC
{
    public class InventoryGlobalNPC : GlobalNPC
    {
        public override void SetupTravelShop(int[] shop, ref int nextSlot)
        {
            if (NPC.downedMechBossAny)
            {
                shop[nextSlot] = ModContent.ItemType<MarshPotion>();
                nextSlot++;
            }
        }
    }
}