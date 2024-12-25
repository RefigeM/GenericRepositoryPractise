using AutoMapper;
using Practise.API.DTOs.Student;
using Practise.API.Entities;

namespace Practise.API.Profiles.StudentProfile
{
	public class StudentProfile : Profile
	{
		public StudentProfile()
		{
			CreateMap<StudentDto,Student>().ReverseMap();	
		}
	}
}
