using EntitySystem.Client.Services;
using Matcher.Shared;
using Matcher.Shared.Domain;

namespace Matcher.Client.Services
{
    public class FolderService : EntityService<Folder>
    {
        public FolderService(IServiceProvider serviceProvider) : base("/api/folder", serviceProvider)
        {
        }
    }
}