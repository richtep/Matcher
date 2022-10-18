using System;
using EntitySystem.Server.Files.Services;
using EntitySystem.Shared.Files.Domain;
using Matcher.Shared;

namespace Matcher.Server.Services;

public class FileService : FileService<FileReference, PersistentFile, PersistentInfo>

{
        public FileService(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }
    }

