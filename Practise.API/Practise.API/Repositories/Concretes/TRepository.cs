using Microsoft.EntityFrameworkCore;
using Practise.API.DAL;
using Practise.API.Entities;
using Practise.API.Repositories.Abstracts;

namespace Practise.API.Repositories.Concretes
{
	public class TRepository<T> : ITRepository<T> where T : BaseEntity, new()
	{
		private readonly ExampleDbContext _context;

		public TRepository(ExampleDbContext context)
		{
			_context = context;
		}

		public IQueryable<T> GetAllT(bool IsTracking, params string[] includes)
		{
			var query = _context.Set<T>().AsQueryable();
			if (!IsTracking)
			{
				query = query.AsNoTracking();
			}
			if (includes.Length > 0)
			{
				foreach (string include in includes)
				{
					query = query.Include(include);
				}
			}
			return query;
		}
	}
}