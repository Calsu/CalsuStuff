using CalsuStuff.Tiles;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace CalsuStuff.Items.Armor
{
	[AutoloadEquip(EquipType.Legs)]
	public class HbjbjbLeggings : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("Power surrounds you."
				+ "\n15% increased movement speed"
				+ "\n25% increased melee damage");
		}

		public override void SetDefaults() {
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = ItemRarityID.Green;
			item.defense = 45;
		}

		public override void UpdateEquip(Player player) {
			player.moveSpeed += 0.05f;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<Placeable.HbjbjbBar>(), 35);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}