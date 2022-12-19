using EntitySystem.Server.Services;
using Matcher.Shared;
using Matcher.Shared.Domain;

namespace Matcher.Server.Services;

public class FolderService : EntityService<Folder>
{
    public FolderService(IServiceProvider serviceProvider) : base(serviceProvider)
    {
    }
}