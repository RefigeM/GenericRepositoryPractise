namespace Practise.API.Entities
{
	public class BaseEntity :AuditableEntity
	{
		public int Id { get; set; }
        public bool IsDeleted { get; set; }
    }
}
