namespace Mythos.Activities.Model
{
	public class Inventory
	{
		public Wallet Wallet { get; set; } = new Wallet();
		public List<Item> Items { get; set; } = new List<Item>();
		public List<Weapon> Weapons { get; set; } = new List<Weapon>();
		public List<Armor> Armor { get; set; } = new List<Armor>();
	}
}
