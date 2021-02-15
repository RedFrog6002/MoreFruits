using Terraria.ModLoader;
using Terraria;
using ReLogic.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Localization;
using System.IO;
using LifeFruitCore;

namespace MoreFruits
{
    public class MoreFruits : Mod
    {
        public override void Load()
        {
			LifeFruitCore.LifeFruitCore.AddFruits((i) => { return Main.player[Main.myPlayer].GetModPlayer<CustomPlayer>().GetHeartColor(i); });
		}

        public override void Unload()
        {

        }
    }
}