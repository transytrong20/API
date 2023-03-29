using API.Data;
using Newtonsoft.Json;
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
                var claims = _httpContextAccessor.HttpContext.User;
                var user = new userlogin();
                user.Name = claims.FindFirstValue(ClaimTypes.Name);
                user.Roles = claims.FindAll(ClaimTypes.Role).Select(x => x.Value).ToArray();

                result = JsonConvert.SerializeObject(user);
            }
           
            return result;
        }
    }

    public class userlogin
    {
        public string Name { get; set; }
        public string[] Roles { get; set; }
    }
}
