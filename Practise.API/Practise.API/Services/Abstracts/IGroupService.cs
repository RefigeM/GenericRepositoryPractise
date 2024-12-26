using Practise.API.Entities;
using Practise.API.Entities;

namespace Practise.API.Services.Abstracts
{
    public interface IGroupService 
    {
        Task<List<Group>> GetAllGroupsAsync();
    }
}
