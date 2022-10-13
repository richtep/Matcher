using EntitySystem.Client.Services;
using Matcher.Shared;

namespace Matcher.Client.Services
{
    public class GameService : EntityService<Game>
    {
        public GameService(IServiceProvider serviceProvider) : base("/api/game", serviceProvider)
        {
        }
    }
}