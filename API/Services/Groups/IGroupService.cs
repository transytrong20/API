using API.Data.Entity;
using API.DTO.Groups;
using Microsoft.AspNetCore.Mvc;

namespace API.Services.Groups
{
    public interface IGroupService
    {
        public Task<ActionResult<Group>> Create(GroupDto group);
    }
}
