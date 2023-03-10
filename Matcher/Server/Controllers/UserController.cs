using EntitySystem.Server.Controllers;
using Matcher.Server.Services;
using Matcher.Shared.Domain;
using Microsoft.AspNetCore.Mvc;

namespace Matcher.Server.Controllers;

[Route("/api/user")]
public class UserController : EntityController<UserService, User>
{
    public UserController(UserService entityService) : base(entityService)
    {
    }
}