using API.DTO.Groups;
using API.Services.Groups;
using API.Services.Products;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.Group
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class GroupController : ControllerBase
    {
        private readonly IGroupService _groupService;
        public GroupController(IGroupService groupService)

        {
            _groupService = groupService;
        }
        [HttpPost("CreateGroup")]
        public async Task<IActionResult> CreateGroup(GroupDto group)
        {
            var result = await _groupService.Create(group);
            return Ok(result);
        }
    }

}
