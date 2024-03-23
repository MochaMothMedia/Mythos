using Mythos.Activities.Model;
using Mythos.Core.Activities;
using Mythos.Core.Database;

namespace Mythos.Activities.Characters
{
    public class CharacterAllGetter : IFetchAllDocuments<Character>
	{
		private readonly IGetAllDocuments<Character> _characterGetter;

		public CharacterAllGetter(IGetAllDocuments<Character> characterGetter)
		{
			_characterGetter = characterGetter;
		}

		public IEnumerable<Character> GetDocuments()
		{
			return _characterGetter.GetAll();
		}
	}
}
