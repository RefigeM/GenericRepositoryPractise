using Microsoft.EntityFrameworkCore;
using Practise.API.Entities;
using Practise.API.Repositories.Abstracts;
using Practise.API.Repositories.Concretes;
using Practise.API.Services.Abstracts;

namespace Practise.API.Services.Implements
{
    public class GroupService : IGroupService
    {
        private readonly ITRepository<Group> _repository;

        public GroupService(ITRepository<Group> repository)
        {
            _repository = repository;
        }

        public async Task<List<Group>> GetAllGroupsAsync()
        {
            IQueryable<Group> queryableGroups = _repository.GetAllT(false, "Teacher");
            List<Group> groups = await queryableGroups.ToListAsync();
            return groups;
        }

      

        
    }
}
