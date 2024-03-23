namespace Mythos.Activities.Model
{
	public class HitDice
	{
		public ushort Quantity { get; set; } = 1;
		public Dice? Dice { get; set; } = Model.Dice.D8;
	}
}
