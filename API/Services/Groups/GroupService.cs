using API.Data;
using API.Data.Entity;
using API.DTO.Groups;
using Microsoft.AspNetCore.Mvc;

namespace API.Services.Groups
{
    public class GroupService : IGroupService
    {
        private readonly DataContext _dataContext;
        public GroupService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<ActionResult<Group>> Create(GroupDto group)
        {
            try
            {
                var result = new Group()
                {
                    GroupName = group.GroupName,
                    Note = group.Note
                };
                await _dataContext.Groups.AddAsync(result);
                await _dataContext.SaveChangesAsync();
                return result;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
