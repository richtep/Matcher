using EntitySystem.Server.Services;
using Matcher.Shared;
using Matcher.Shared.Domain;

namespace Matcher.Server.Services;

public class UserService : EntityService<User>
{
    public UserService(IServiceProvider serviceProvider) : base(serviceProvider)
    {
    }
}