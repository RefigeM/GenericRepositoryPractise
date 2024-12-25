using Microsoft.AspNetCore.Mvc;
using Practise.API.Entities;
using Practise.API.Services.Abstracts;

namespace Practise.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class StudentsController : ControllerBase
	{
		private readonly IStudentService _studentService;

		public StudentsController(IStudentService studentService)
		{
			_studentService = studentService;
		}

		[HttpGet]
		public async Task<IActionResult> GetAllAsync()
		{
			List<Student> students = await _studentService.GetAllStudentsAsync();
			return Ok(students);	
		}
	}
}
