using CalsuStuff.Tiles;
using CalsuStuff.Items;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace CalsuStuff.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class HbjbjbHelmet : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("Power surrounds you."
						+ "\n15% increased melee damage");
		}

		public override void SetDefaults() {
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = ItemRarityID.Green;
			item.defense = 30;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs) {
			return body.type == ModContent.ItemType<HbjbjbShirt>() && legs.type == ModContent.ItemType<HbjbjbLeggings>();
		}

		public override void UpdateArmorSet(Player player) {
			player.setBonus = "trollface.jpg";
			player.allDamage -= 0.2f;
			/* Here are the individual weapon class bonuses.
			player.meleeDamage -= 0.2f;
			player.thrownDamage -= 0.2f;
			player.rangedDamage -= 0.2f;
			player.magicDamage -= 0.2f;
			player.minionDamage -= 0.2f;
			*/
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<Placeable.HbjbjbBar>(), 30);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}