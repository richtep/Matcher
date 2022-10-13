using EntitySystem.Client.Services;
using Matcher.Shared;

namespace Matcher.Client.Services
{
    public class GroupService : EntityService<Group>
    {
        public GroupService(IServiceProvider serviceProvider) : base("/api/group", serviceProvider)
        {
        }
    }
}