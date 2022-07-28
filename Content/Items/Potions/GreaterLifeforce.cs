using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;
using Microsoft.Xna.Framework;

namespace PotionsExpanded.Content.Items.Potions
{
    public class GreaterLifeforce : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Increases max life by 35%");
            DisplayName.SetDefault("Greater Lifeforce Potion");

            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 20;

            ItemID.Sets.DrinkParticleColors[Type] = new Color[3] {
                new Color(255, 0, 0),
                new Color(200, 80, 60),
                new Color(207, 58, 36),
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
            Item.buyPrice(platinum: 1, gold: 50);
            Item.buffType = ModContent.BuffType<Buffs.GreaterLifeforceBuff>();

            // this time is measured in ticks so we multiply by 60
            // seconds * ticks per second
            Item.buffTime = 300 * 60;
        }
    }
}