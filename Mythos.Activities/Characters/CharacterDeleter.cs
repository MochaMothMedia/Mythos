using Mythos.Activities.Model;
using Mythos.Core.Activities;
using Mythos.Core.Database;

namespace Mythos.Activities.Characters
{
    internal class CharacterDeleter : Core.Activities.IDeleteADocument<Character>
	{
		private readonly Core.Database.IDeleteADocument<Character> _characterDeleter;

		public CharacterDeleter(Core.Database.IDeleteADocument<Character> characterDeleter)
		{
			_characterDeleter = characterDeleter;
		}

		public Character? Delete(string ID)
		{
			return _characterDeleter.Delete(ID);
		}
	}
}
