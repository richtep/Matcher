using EntitySystem.Client.Services;
using Matcher.Shared;
using Matcher.Shared.Domain;

namespace Matcher.Client.Services
{
    public class UserService : EntityService<User>
    {
        public UserService(IServiceProvider serviceProvider) : base("/api/user", serviceProvider)
        {
        }
    }
}