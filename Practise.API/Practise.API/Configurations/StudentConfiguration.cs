using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Practise.API.Entities;

namespace Practise.API.Configurations
{
	public class StudentConfiguration : IEntityTypeConfiguration<Student>
	{
		public void Configure(EntityTypeBuilder<Student> builder)
		{
			builder
				.HasOne(x => x.Group)
				.WithMany(y => y.Students)
				.HasForeignKey(x => x.GroupId);

			//builder
			//	.Property(x => x.Name);

		}
	}
}
