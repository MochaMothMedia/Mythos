using System.Text.RegularExpressions;
using System;

namespace Mythos.Activities.Model
{
	public static class DnD5eSettings
	{
		public static readonly KeyValuePair<string, string>[] SKILLS = new KeyValuePair<string, string>[]
		{
			new KeyValuePair<string, string>("Acrobatics", "Dexterity"),
			new KeyValuePair<string, string>("Animal Handling", "Wisdom"),
			new KeyValuePair<string, string>("Arcana", "Intelligence"),
			new KeyValuePair<string, string>("Athletics", "Strength"),
			new KeyValuePair<string, string>("Deception", "Charisma"),
			new KeyValuePair<string, string>("History", "Intelligence"),
			new KeyValuePair<string, string>("Insight", "Wisdom"),
			new KeyValuePair<string, string>("Intimidation", "Charisma"),
			new KeyValuePair<string, string>("Investigation", "Intelligence"),
			new KeyValuePair<string, string>("Medicine", "Wisdom"),
			new KeyValuePair<string, string>("Nature", "Intelligence"),
			new KeyValuePair<string, string>("Perception", "Wisdom"),
			new KeyValuePair<string, string>("Performance", "Charisma"),
			new KeyValuePair<string, string>("Persuasion", "Charisma"),
			new KeyValuePair<string, string>("Religion", "Intelligence"),
			new KeyValuePair<string, string>("Sleight of Hand", "Dexterity"),
			new KeyValuePair<string, string>("Stealth", "Dexterity"),
			new KeyValuePair<string, string>("Survival", "Wisdom")
		};

		public static readonly KeyValuePair<string, string>[] SAVES = new KeyValuePair<string, string>[]
		{
			new KeyValuePair<string, string>("Strength Save", "Strength"),
			new KeyValuePair<string, string>("Dexterity Save", "Dexterity"),
			new KeyValuePair<string, string>("Constitution Save", "Constitution"),
			new KeyValuePair<string, string>("Intelligence Save", "Intelligence"),
			new KeyValuePair<string, string>("Wisdom Save", "Wisdom"),
			new KeyValuePair<string, string>("Charisma Save", "Charisma")
		};
	}
}
