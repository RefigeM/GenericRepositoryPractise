namespace Practise.API.Entities
{
	public class Group :BaseEntity
	{
		public string Name { get; set; } 
		public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
        public DateTime CreatedDate { get; set; }
        public ICollection<Student> Students { get; set; }

    }
}
