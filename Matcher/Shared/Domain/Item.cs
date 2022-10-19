using System.ComponentModel.DataAnnotations;
using EntitySystem.Shared.Fluent.Domain;

namespace Matcher.Shared.Domain;

public class Item : Entity
{
    [Required]
    public virtual Group Group { get; set; }
    
    [Required]
    public virtual string Value { get; set; }
}
