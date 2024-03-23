using Mythos.Activities.Model;
using Mythos.Utilities;

namespace Mythos.MemoryDatabase.Characters
{
    public class CharacterDocument
	{
		public string? ID { get; set; }
		public string? Name { get; set; }
		public Race? Race { get; set; }
		public List<Class>? ClassList { get; set; }
		public CoreStats? CoreStats { get; set; }
		public List<Skill>? Skills { get; set; }
		public List<Skill>? SavingThrows { get; set; }
		public Inventory? Inventory { get; set; }
		public List<string>? Proficiencies { get; set; }
		public List<string>? Languages { get; set; }
		public string? Backstory { get; set; }

		public static implicit operator Character(CharacterDocument? characterModel)
		{
			return DataConverter.ConvertByPropertyNames<Character, CharacterDocument>(characterModel) ?? new CharacterDocument();
		}

		public static implicit operator CharacterDocument(Character? character)
		{
			return DataConverter.ConvertByPropertyNames<CharacterDocument, Character>(character) ?? new Character();
		}
	}
}
