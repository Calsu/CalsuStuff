using Terraria.ID;
using Terraria.ModLoader;

namespace CalsuStuff.Items.Placeable
{
	public class HbjbjbChest : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("=)");
		}

		public override void SetDefaults() {
			item.width = 26;
			item.height = 22;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.consumable = true;
			item.value = 500;
			item.createTile = ModContent.TileType<Tiles.HbjbjbChest>();
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Chest);
			recipe.AddIngredient(ModContent.ItemType<HbjbjbBar>(), 10);
			recipe.AddIngredient(ItemID.Wood, 10);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}