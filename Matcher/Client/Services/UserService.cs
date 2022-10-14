using EntitySystem.Client.Services;
using Matcher.Shared;

namespace Matcher.Client.Services
{
    public class UserService : EntityService<User>
    {
        public UserService(IServiceProvider serviceProvider) : base("/api/user", serviceProvider)
        {
        }
    }
}