using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Testmod.Items.Weapons
{
    public class Netlauncher : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Net Launcher");
            Tooltip.SetDefault("Knock your foes out of the sky");
        }

        public override void SetDefaults()
        {
            item.damage = 5;
            item.ranged = true;
            item.width = 24;
            item.width = 8;
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 4;
            item.value = 10000;
            item.rare = 2;
            item.UseSound = SoundID.Item11;
            item.autoReuse = false;
            item.shoot = 10;
            item.shootSpeed = 8f;
            item.useAmmo = ItemID.Rope;
        }
    }
}