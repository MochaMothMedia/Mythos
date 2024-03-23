using Mythos.Activities.Model;
using Mythos.Core.Activities;
using Mythos.Core.Database;

namespace Mythos.Activities.Characters
{
    public class CharacterSingleGetter : IFetchADocument<Character>
	{
		private readonly IGetADocument<Character> _characterGetter;

		public CharacterSingleGetter(IGetADocument<Character> characterGetter)
		{
			_characterGetter = characterGetter;
		}

		public Character? GetDocument(string ID)
		{
			return _characterGetter.Get(ID);
		}
	}
}
