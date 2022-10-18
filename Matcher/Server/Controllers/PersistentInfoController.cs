using EntitySystem.Server.Controllers;
using Matcher.Server.Services;
using Matcher.Shared;
using Microsoft.AspNetCore.Mvc;

namespace Matcher.Server.Controllers;

[Route("api/persistent-infos")]
public class PersistentInfoController : EntityController<PersistentInfoService, PersistentInfo>
{
    public PersistentInfoController(PersistentInfoService persistentInfoService) : base(persistentInfoService)
    {
    }
}