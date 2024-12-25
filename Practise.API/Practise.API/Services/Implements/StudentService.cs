using Microsoft.EntityFrameworkCore;
using Practise.API.Entities;
using Practise.API.Repositories.Abstracts;
using Practise.API.Repositories.Concretes;
using Practise.API.Services.Abstracts;

namespace Practise.API.Services.Implements
{
	public class StudentService : IStudentService
	{
		private readonly ITRepository<Student> _repository;

		public StudentService(ITRepository<Student> repository)
		{
			_repository = repository;
		}

		public async Task<List<Student>> GetAllStudentsAsync()
		{
			IQueryable<Student> queryableStudents = _repository.GetAllT(false,"Group");
			List<Student> students = await queryableStudents.ToListAsync();
			return students;

		}


	}
}
