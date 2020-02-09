using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Testmod.NPCs.Boss
{
    [AutoloadBossHead]
    public class Eymis : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Eymis");
        }
        public override void SetDefaults()
        {
            npc.aiStyle = 5;
            npc.lifeMax = 15000;
            npc.damage = 50;
            npc.defense = 25;
            npc.knockBackResist = 0f;
            npc.width = 100;
            npc.height = 100;
            animationType = NPCID.DemonEye;
            Main.npcFrameCount[npc.type] = 2;
            npc.value = Item.buyPrice(0, 40, 75, 45);
            npc.npcSlots = 1f;
            npc.boss = true;
            npc.lavaImmune = true;
            npc.noGravity = true;
            npc.noTileCollide = true;
            npc.HitSound = SoundID.Item9;
            npc.DeathSound = SoundID.NPCDeath6;
            npc.buffImmune[24] = true;
            music = MusicID.Boss2;
        }

        public override void BossLoot(ref string name, ref int potionType)
        {
            potionType = ItemID.HealingPotion;
            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Elementalessence"));
        }
        public override void ScaleExpertStats(int numPlayers, float bossLifeScale)
        {
            npc.lifeMax = (int)(npc.lifeMax * 0.579f * bossLifeScale);
            npc.damage = (int)(npc.damage * 0.6f);
        }
    }
}