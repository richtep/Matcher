using EntitySystem.Client.Services;
using Matcher.Shared;

namespace Matcher.Client.Services
{
    public class ItemService : EntityService<Item>
    {
        public ItemService(IServiceProvider serviceProvider) : base("/api/item", serviceProvider)
        {
        }
    }
}