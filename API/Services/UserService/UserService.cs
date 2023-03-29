using API.Data;
using System.Security.Claims;

namespace API.Services.UserService
{
    public class UserService : IUserService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly DataContext _dataContext;

        public UserService(IHttpContextAccessor httpContextAccessor
            , DataContext dataContext)
        {
            _dataContext = dataContext;
            _httpContextAccessor = httpContextAccessor;
        }

        public string GetMyName()
        {
            var result = string.Empty;

            if (_httpContextAccessor.HttpContext != null)
            {
                result = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.Name);

            }
           
            return result;
        }
    }
}
