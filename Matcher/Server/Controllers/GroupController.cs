using EntitySystem.Server.Controllers;
using Matcher.Server.Services;
using Matcher.Shared;
using Microsoft.AspNetCore.Mvc;

namespace Matcher.Server.Controllers;

[Route("/api/group")]
public class GroupController : EntityController<GroupService, Group>
{
    public GroupController(GroupService entityService) : base(entityService)
    {
    }
}