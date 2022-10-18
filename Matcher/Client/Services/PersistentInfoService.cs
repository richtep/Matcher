using System;
using EntitySystem.Client.Files.Services;
using EntitySystem.Client.Services;
using Matcher.Shared;

namespace Matcher.Client.Services;

public class PersistentInfoService : EntityService<PersistentInfo>, IPersistentInfoService<FileReference, PersistentFile, PersistentInfo>
{
    public PersistentInfoService(IServiceProvider serviceProvider) : base("/api/persistent-infos", serviceProvider)
    {
    }
}