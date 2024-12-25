using Practise.API.Entities;
using Practise.API.Repositories.Abstracts;
using Practise.API.Repositories.Concretes;
using Practise.API.Services.Abstracts;
using Practise.API.Services.Implements;

namespace Practise.API
{
	public static class ServiceRegistration
	{
		public static void AddServices(this IServiceCollection services) 
		{
			services.AddScoped<IStudentService, StudentService>();
			services.AddScoped<ITRepository<Student>, TRepository<Student>>();
			services.AddScoped<ITRepository<Group>, TRepository<Group>>();

		}
	}
}
