using Mythos.Activities.Model;
using Mythos.Core.Activities;
using Mythos.Core.Database;
using System.Reflection.Metadata;

namespace Mythos.Activities.Characters
{
    internal class CharacterUpdater : IUpdateADocument<Character>
	{
		private readonly ISaveADocument<Character> _characterSaver;

		public CharacterUpdater(ISaveADocument<Character> characterSaver)
		{
			_characterSaver = characterSaver;
			//
		}

		public Character UpdateDocument(Character entity)
		{
			_characterSaver.SaveToDatabase(entity);
			return entity;
		}
	}
}
