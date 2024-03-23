using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Mythos.Activities.Model;
using Mythos.Core.Activities;
using Mythos.Core.Logging;
using Newtonsoft.Json;

namespace Mythos.ASPWebAPI.Characters
{
    public class CharacterController : Controller
	{
		private readonly ILog _log;
		private readonly ICRUDActivity<Character> _characterActivity;

		public CharacterController(ILog log, ICRUDActivity<Character> characterActivity)
		{
			_log = log;
			_characterActivity = characterActivity;
		}

		/// <summary>
		/// Retrieves all Characters in the DB.
		/// </summary>
		/// <returns>List of all Characters</returns>
		[HttpGet("/character")]
		public async Task<ActionResult> Index()
		{
			_log.LogInfo("Request received to fetch all characters.");
			IEnumerable<Character> characters = await Task.Run(() => _characterActivity.GetAll());
			_log.LogInfo($"Characters fetched: {JsonConvert.SerializeObject(characters)}");
			return Ok(characters);
		}

		/// <summary>
		/// Retrieves the details of a given Character.
		/// </summary>
		/// <param name="ID">Unique Identifier of the desired Character</param>
		/// <returns>Character details</returns>
		[HttpGet("/character/{ID}")]
		public async Task<ActionResult> Details(string ID)
		{
			_log.LogInfo($"Request received to fetch Character with ID: '{ID}'");
			Character? character = await Task.Run(() => _characterActivity.Get(ID));

			if (character == null)
			{
				_log.LogWarning($"Character with ID '{ID}' was not found!");
				return NotFound();
			}

			_log.LogInfo($"Character found: {JsonConvert.SerializeObject(character)}");
			return Ok(character);
		}

		/// <summary>
		/// Creates a new Character with provided details.
		/// </summary>
		/// <param name="character">Character details to be created</param>
		/// <returns>Created Character</returns>
		[HttpPost("/character")]
		public async Task<ActionResult> Create([FromBody] Character character)
		{
			_log.LogInfo($"Request received to create character: {JsonConvert.SerializeObject(character)}");
			Character createdCharacter = await Task.Run(() => _characterActivity.Add(character));
			_log.LogInfo($"Character created: {JsonConvert.SerializeObject(createdCharacter)}");
			return Created($"/character/{createdCharacter.ID}", createdCharacter);
		}

		/// <summary>
		/// Applies a Patch Document to the Character with given ID and saves the changes in the DB.
		/// </summary>
		/// <param name="characterPatchDocument">Patch Document with desired changes</param>
		/// <param name="ID">Unique identifier of the desired Character</param>
		/// <returns>The updated Character details</returns>
		[HttpPatch("/character/{ID}")]
		public async Task<ActionResult> Update([FromBody] JsonPatchDocument<Character> characterPatchDocument, string ID)
		{
			_log.LogInfo($"Request received to patch character: '{ID}' and patchdoc: {JsonConvert.SerializeObject(characterPatchDocument)}");
			Character? character = await Task.Run(() => _characterActivity.Get(ID));

			if (character == null)
			{
				_log.LogWarning($"Character with ID '{ID}' was not found!");
				return NotFound();
			}

			_log.LogInfo($"Character found: {JsonConvert.SerializeObject(character)}");
			await Task.Run(() => characterPatchDocument.ApplyTo(character));

			_log.LogInfo($"Character patched: {JsonConvert.SerializeObject(character)}");
			await Task.Run(() => _characterActivity.Update(character));

			return Created($"/character/{character.ID}", character);
		}

		/// <summary>
		/// Removes a Character from the DB.
		/// </summary>
		/// <param name="ID">Unique identifier of the desired Character</param>
		/// <returns>The deleted Character</returns>
		[HttpDelete("/character/{ID}")]
		public async Task<ActionResult> Delete(string ID)
		{
			_log.LogInfo($"Request received to delete character with ID: '{ID}'");
			Character? deletedCharacter = await Task.Run(() => _characterActivity.Remove(ID));

			if (deletedCharacter == null)
			{
				_log.LogInfo($"Character with ID '{ID}' not found!");
				return NotFound();
			}

			_log.LogInfo($"Character deleted: {JsonConvert.SerializeObject(deletedCharacter)}");
			return Ok(deletedCharacter);
		}
	}
}
