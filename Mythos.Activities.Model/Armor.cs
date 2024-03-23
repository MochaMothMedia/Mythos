namespace Mythos.Activities.Model
{
	public class Armor
	{
		public string? Name { get; set; }
		public string? Type { get; set; }
		public ushort Quantity { get; set; } = 1;
		public ushort IndividualWeight { get; set; } = 1;
		public ushort BaseAC { get; set; } = 15;
	}
}
