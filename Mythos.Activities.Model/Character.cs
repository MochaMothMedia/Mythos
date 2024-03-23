namespace Mythos.Activities.Model
{
    public class Character
    {
        public string? ID { get; set; }
        public string? Name { get; set; }
        public Race Race { get; set; } = new Race();
        public List<Class> ClassList { get; set; } = new List<Class>();
        public CoreStats CoreStats { get; set; } = new CoreStats();
        public List<Skill> Skills { get; set; } = new List<Skill>();
        public List<Skill> SavingThrows { get; set; } = new List<Skill>();
        public Inventory Inventory { get; set; } = new Inventory();
		public List<string> Proficiencies { get; set; } = new List<string>();
        public List<string> Languages { get; set; } = new List<string>();
        public string Backstory { get; set; } = "";
	}
}
