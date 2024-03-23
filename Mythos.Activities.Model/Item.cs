namespace Mythos.Activities.Model
{
	public class Item
	{
		public string? Name { get; set; }
		public string? Description { get; set; }
		public string? HyperLink { get; set; }
		public ushort Quantity { get; set; } = 1;
		public ushort IndividualWeight { get; set; } = 1;
	}
}
