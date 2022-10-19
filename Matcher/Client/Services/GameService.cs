using EntitySystem.Client.Services;
using Matcher.Shared;
using Matcher.Shared.Domain;

namespace Matcher.Client.Services
{
    public class GameService : EntityService<Game>
    {
        public GameService(IServiceProvider serviceProvider) : base("/api/game", serviceProvider)
        {
        }
    }
}