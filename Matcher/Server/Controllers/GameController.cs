using EntitySystem.Server.Controllers;
using Matcher.Server.Services;
using Matcher.Shared;
using Microsoft.AspNetCore.Mvc;

namespace Matcher.Server.Controllers;

[Route("/api/game")]
public class GameController : EntityController<GameService, Game>
{
    public GameController(GameService entityService) : base(entityService)
    {
    }
}