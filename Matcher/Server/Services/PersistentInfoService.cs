using System;
using EntitySystem.Server.Files.Services;
using EntitySystem.Server.Services;
using Matcher.Shared;

namespace Matcher.Server.Services;

public class PersistentInfoService : EntityService<PersistentInfo>, IPersistentInfoService<FileReference, PersistentFile, PersistentInfo>
{
    public PersistentInfoService(IServiceProvider serviceProvider) : base(serviceProvider)
    {
    }
}