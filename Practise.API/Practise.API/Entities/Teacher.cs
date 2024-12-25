namespace Practise.API.Entities
{
	public class Teacher : BaseEntity
	{
		public string Name { get; set; } 
		public string Surname { get; set; }
		public string Specialization { get; set; } 
		public DateTime HireDate { get; set; }
        public ICollection<Group> Groups { get; set; }
    }
}
