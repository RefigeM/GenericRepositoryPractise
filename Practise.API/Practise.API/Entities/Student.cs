namespace Practise.API.Entities
{
	public class Student :BaseEntity
	{
		public string Name { get; set; } 
		public string Surname { get; set; } 
		public string Code { get; set; } 
		public int Age { get; set; }
		public int GroupId { get; set; }
        public Group Group { get; set; }
    }
}
