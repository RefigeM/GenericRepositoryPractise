using Practise.API.Entities;

namespace Practise.API.Repositories.Abstracts
{
	public interface ITRepository<T> where T : BaseEntity, new()
	{
		IQueryable<T> GetAllT(bool IsTracking, params string[] includes);
	}
}
