using EntitySystem.Server.Services;
using Matcher.Shared;
using Matcher.Shared.Domain;

namespace Matcher.Server.Services;

public class ItemService : EntityService<Item>
{
    public ItemService(IServiceProvider serviceProvider) : base(serviceProvider)
    {
    }
}