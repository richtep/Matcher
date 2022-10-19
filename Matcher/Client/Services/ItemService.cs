using EntitySystem.Client.Services;
using Matcher.Shared;
using Matcher.Shared.Domain;

namespace Matcher.Client.Services
{
    public class ItemService : EntityService<Item>
    {
        public ItemService(IServiceProvider serviceProvider) : base("/api/item", serviceProvider)
        {
        }
    }
}