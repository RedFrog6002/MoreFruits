using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria;
using Microsoft.Xna.Framework;

namespace MoreFruits
{
    public class RedCrystal : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Life Cherries");
            Tooltip.SetDefault("Increases your life by " + Consts.redMult + " once you have max life fruit");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.LifeFruit);
        }

        public override bool CanUseItem(Player player)
        {
            return player.statLifeMax == 500 && player.GetModPlayer<CustomPlayer>().usedRedCrystals < Consts.maxRedCrystals;
        }

        public override bool UseItem(Player player)
        {
            player.statLifeMax2 += Consts.redMult;
            player.statLife += Consts.redMult;
            player.GetModPlayer<CustomPlayer>().usedRedCrystals++;
            if (Main.myPlayer == player.whoAmI)
                player.HealEffect(Consts.redMult, true);
            return true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.LifeFruit, 10);
            recipe.AddIngredient(ItemID.RedDye);
            recipe.AddTile(TileID.AdamantiteForge);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    public class BlueCrystal : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Life Blueberries");
            Tooltip.SetDefault("Increases your life by " + Consts.blueMult + " once you have max life fruit");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.LifeFruit);
        }

        public override bool CanUseItem(Player player)
        {
            return player.statLifeMax == 500 && player.GetModPlayer<CustomPlayer>().usedBlueCrystals < Consts.maxBlueCrystals;
        }

        public override bool UseItem(Player player)
        {
            player.statLifeMax2 += Consts.blueMult;
            player.statLife += Consts.blueMult;
            player.GetModPlayer<CustomPlayer>().usedBlueCrystals++;
            if (Main.myPlayer == player.whoAmI)
                player.HealEffect(Consts.blueMult, true);
            return true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.LifeFruit, 10);
            recipe.AddIngredient(ItemID.BlueDye);
            recipe.AddTile(TileID.AdamantiteForge);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    public class GreenCrystal : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Life Grapes");
            Tooltip.SetDefault("Increases your life by " + Consts.greenMult + " once you have max life fruit");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.LifeFruit);
        }

        public override bool CanUseItem(Player player)
        {
            return player.statLifeMax == 500 && player.GetModPlayer<CustomPlayer>().usedGreenCrystals < Consts.maxGreenCrystals;
        }

        public override bool UseItem(Player player)
        {
            player.statLifeMax2 += Consts.greenMult;
            player.statLife += Consts.greenMult;
            player.GetModPlayer<CustomPlayer>().usedGreenCrystals++;
            if (Main.myPlayer == player.whoAmI)
                player.HealEffect(Consts.greenMult, true);
            return true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.LifeFruit, 10);
            recipe.AddIngredient(ItemID.GreenDye);
            recipe.AddTile(TileID.AdamantiteForge);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
