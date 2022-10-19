using EntitySystem.Client.Services;
using Matcher.Shared;
using Matcher.Shared.Domain;

namespace Matcher.Client.Services
{
    public class GroupService : EntityService<Group>
    {
        public GroupService(IServiceProvider serviceProvider) : base("/api/group", serviceProvider)
        {
        }
    }
}