using System;
using EntitySystem.Client.Files.Services;
using EntitySystem.Client.Services;
using Matcher.Shared;

namespace Matcher.Client.Services;

public class PersistentFileService : EntityService<PersistentFile>, IPersistentFileService<PersistentFile>
{
    public PersistentFileService(IServiceProvider serviceProvider) : base("/api/persistent-files", serviceProvider)
    {
    }
}