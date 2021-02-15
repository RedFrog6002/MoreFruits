using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;

namespace MoreFruits
{
    public class CustomPlayer : ModPlayer
    {
        public int usedRedCrystals = 0;
        public int usedBlueCrystals = 0;
        public int usedGreenCrystals = 0;

        public override void ResetEffects()
        {
            player.statLifeMax2 += CalculateCrystalHealth();
        }

        public override void SyncPlayer(int toWho, int fromWho, bool newPlayer)
        {
            ModPacket packet = mod.GetPacket();
            packet.Write(usedRedCrystals);
            packet.Write(usedBlueCrystals);
            packet.Write(usedGreenCrystals);
            packet.Send(toWho, fromWho);
        }

        public override TagCompound Save()
        {
            return new TagCompound()
            {
                { "RedCrystals", usedRedCrystals },
                { "BlueCrystals", usedBlueCrystals },
                { "GreenCrystals", usedGreenCrystals },
            };
        }

        public override void Load(TagCompound tag)
        {
            usedRedCrystals = tag.GetInt("RedCrystals");
            usedBlueCrystals = tag.GetInt("BlueCrystals");
            usedGreenCrystals = tag.GetInt("GreenCrystals");
        }

        public Color GetHeartColor(int i)
        {
            bool red = usedRedCrystals >= i;
            bool blue = usedBlueCrystals >= i;
            bool green = usedGreenCrystals >= i;
            if (red && blue && !green)
                return Color.Purple;
            else if (red && !blue && green)
                return Color.DarkOrange;
            else if (red && !blue && !green)
                return Color.Red;
            else if (!red && blue && green)
                return Color.DarkSeaGreen;
            else if (!red && !blue && green)
                return Color.Green;
            else if (!red && blue && !green)
                return Color.Blue;
            else if (red && blue && green)
                return Color.LightPink;
            else
                return Color.Transparent;
        }

        public int CalculateCrystalHealth()
        {
            int redHealth = usedRedCrystals * Consts.redMult;
            int blueHealth = usedBlueCrystals * Consts.blueMult;
            int greenHealth = usedGreenCrystals * Consts.greenMult;

            return redHealth + blueHealth + greenHealth;
        }
    }
}
