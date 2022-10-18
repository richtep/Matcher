using EntitySystem.Server.Controllers;
using Matcher.Server.Services;
using Matcher.Shared;
using Microsoft.AspNetCore.Mvc;

namespace Matcher.Server.Controllers;

[Route("api/file-references")]
[ApiController]
public class FileReferenceController : EntityController<FileReferenceService, FileReference>
{
    public FileReferenceController(FileReferenceService entityService) : base(entityService)
    {
    }
}