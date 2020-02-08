using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Testmod.Items
{
    public class Elementalessence : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Elemental Essence");
            Tooltip.SetDefault("The material that holds the universe together");
        }
        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 999;
            item.value = 100;
            item.rare = ItemRarityID.Expert;
        }
    }
}