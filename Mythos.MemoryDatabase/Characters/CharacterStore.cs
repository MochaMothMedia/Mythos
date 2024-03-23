namespace Mythos.MemoryDatabase.Characters
{
	internal static class CharacterStore
	{
		public static Dictionary<string, CharacterDocument> Characters { get; } = new Dictionary<string, CharacterDocument>();
	}
}
