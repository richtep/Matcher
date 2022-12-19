using EntitySystem.Server.Controllers;
using Matcher.Server.Services;
using Matcher.Shared.Domain;
using Microsoft.AspNetCore.Mvc;

namespace Matcher.Server.Controllers;

[Route("/api/folder")]
public class FolderController : EntityController<FolderService, Folder>
{
    public FolderController(GameService entityService) : base(entityService)
    {
    }
}