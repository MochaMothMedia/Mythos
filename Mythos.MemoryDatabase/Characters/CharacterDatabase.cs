using Mythos.Activities.Model;
using Mythos.Core.Database;
using Mythos.Core.Logging;

namespace Mythos.MemoryDatabase.Characters
{
    public class CharacterDatabase : IGetAllDocuments<Character>, IGetADocument<Character>, ISaveADocument<Character>, IDeleteADocument<Character>
	{
		private readonly ILog _logger;
		public CharacterDatabase(ILog logger)
		{
			_logger = logger;
		}

		public IEnumerable<Character> GetAll()
		{
			return CharacterStore.Characters.Select(character => (Character)character.Value);
		}

		public Character? Get(string ID)
		{
			if (!CharacterStore.Characters.ContainsKey(ID))
			{
				return null;
			}

			return CharacterStore.Characters[ID];
		}

		public bool SaveToDatabase(Character entity)
		{
			if (entity.ID == null)
			{
				return false;
			}

			CharacterStore.Characters[entity.ID] = entity;
			return true;
		}

		public Character? Delete(string ID)
		{
			if (ID == null || !CharacterStore.Characters.ContainsKey(ID))
			{
				return null;
			}

			Character deletedCharacter = CharacterStore.Characters[ID];
			CharacterStore.Characters.Remove(ID);
			return deletedCharacter;
		}
	}
}
