using System.ComponentModel.DataAnnotations;
using EntitySystem.Shared.Fluent.Domain;

namespace Matcher.Shared.Domain;

public class Folder : Entity
{
    [Required]
    public virtual string Name { get; set; }

    public virtual Folder ParentFolder { get; set; }
}
