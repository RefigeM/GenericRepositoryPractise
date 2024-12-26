using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Practise.API.Entities;
using Practise.API.Services.Abstracts;

namespace Practise.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupsController : ControllerBase
    {
        private readonly IGroupService _service;

        public GroupsController(IGroupService service)
        {
            _service = service;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
        List<Group> groups =  await _service.GetAllGroupsAsync();
            return Ok(groups);  
        }
    }
}
