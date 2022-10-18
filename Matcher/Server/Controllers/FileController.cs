using System;
using EntitySystem.Server.Files.Controllers;
using Matcher.Shared;
using Microsoft.AspNetCore.Mvc;

namespace Matcher.Server.Controllers;


[Route("api/file")]
public class FileController : FileController<FileReference>
{
    public FileController(IServiceProvider serviceProvider) : base(serviceProvider)
    {
    }
}