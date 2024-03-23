using Mythos.Activities.Model;
using Mythos.Core.Activities;
using Mythos.Core.Database;

namespace Mythos.Activities.Characters
{
    public class CharacterCreator : ICreateADocument<Character>
	{
		private readonly ISaveADocument<Character> _characterSaver;

		public CharacterCreator(ISaveADocument<Character> characterSaver)
		{
			_characterSaver = characterSaver;
		}

		public Character CreateDocument(Character document)
		{
			document.ID = Guid.NewGuid().ToString();

			if (document.Skills.Count == 0)
			{
				for (int i = 0; i < DnD5eSettings.SKILLS.Length; i++)
				{
					document.Skills.Add(new Skill()
					{
						Name = DnD5eSettings.SKILLS[i].Key,
						Ability = DnD5eSettings.SKILLS[i].Value
					});
				}
			}

			if (document.SavingThrows.Count == 0)
			{
				for (int i = 0; i < DnD5eSettings.SAVES.Length; i++)
				{
					document.SavingThrows.Add(new Skill()
					{
						Name = DnD5eSettings.SAVES[i].Key,
						Ability = DnD5eSettings.SAVES[i].Value
					});
				}
			}

			_characterSaver.SaveToDatabase(document);
			return document;
		}
	}
}
