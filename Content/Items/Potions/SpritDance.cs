using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;
using Microsoft.Xna.Framework;


namespace PotionsExpanded.Content.Items.Potions
{
    public class SpiritDance : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Spirit Dance Potion");
            Tooltip.SetDefault("Moderately increases defense, mana, and magic attack speed");

            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 20;

            ItemID.Sets.DrinkParticleColors[Type] = new Color[3] {
                new Color(165, 158, 255),
                new Color(84, 69, 255),
                new Color(49, 39, 162)
            };
        }

        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 25;
            Item.useStyle = ItemUseStyleID.DrinkLiquid;
            Item.useTurn = true;
            Item.useAnimation = 15;
            Item.useTime = 15;
            Item.UseSound = SoundID.Item3;
            Item.maxStack = 30;
            Item.consumable = true;
            Item.rare = ItemRarityID.Cyan;
            Item.buyPrice(gold: 55);
            Item.buffType = ModContent.BuffType<Buffs.SpiritDanceBuff>();
            Item.buffTime = 270 * 60;
        }
    }
}