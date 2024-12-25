using Practise.API.Entities;

namespace Practise.API.Services.Abstracts
{
	public interface IStudentService
	{
	 public  Task<List<Student>> GetAllStudentsAsync();
	}
}
