using EntitySystem.Server.Controllers;
using Matcher.Server.Services;
using Matcher.Shared;
using Microsoft.AspNetCore.Mvc;

namespace Example.FileManager.Server.Controllers;

[Route("api/persistent-files")]
public class PersistentFileController : EntityController<PersistentFileService, PersistentFile>
{
    public PersistentFileController(PersistentFileService persistentInfoService) : base(persistentInfoService)
    {
    }
}