using Microsoft.EntityFrameworkCore;
using Practise.API.Entities;

namespace Practise.API.DAL
{
	public class ExampleDbContext : DbContext
	{
		public DbSet<Student> Students { get; set; }
		public DbSet<Teacher> Teachers { get; set; }
		public DbSet<Group> Groups { get; set; }

		public ExampleDbContext(DbContextOptions options) : base(options)
        {            
        }
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfigurationsFromAssembly(typeof(ExampleDbContext).Assembly);

			base.OnModelCreating(modelBuilder);

		}
	}
}
