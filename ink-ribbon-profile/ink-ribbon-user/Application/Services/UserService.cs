using ink_ribbon_profile_api.Domain.Interfaces.Services;

namespace ink_ribbon_profile_api.Application.Services
{
    public class UserService : IUserService
    {
        private readonly ILogger<UserService> _logger;

        public UserService(ILogger<UserService> logger){_logger = logger;}

        public Task Delete()
        {
            throw new NotImplementedException();
        }

        public Task Get()
        {
            throw new NotImplementedException();
        }

        public Task Insert()
        {
            throw new NotImplementedException();
        }

        public Task Update()
        {
            throw new NotImplementedException();
        }
    }
}
