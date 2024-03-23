namespace Mythos.Activities.Model
{
	public class Weapon
	{
		public string? Name { get; set; }
		public string? Type { get; set; }
		public ushort Quantity { get; set; } = 1;
		public ushort IndividualWeight { get; set; } = 1;
		public HitDice HitDice { get; set; } = new HitDice();
		public List<WeaponProperty> Properties { get; set; } = new List<WeaponProperty>();
	}
}
