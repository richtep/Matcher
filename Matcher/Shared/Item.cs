using EntitySystem.Shared.Fluent.Domain;
using System.ComponentModel.DataAnnotations;

namespace Matcher.Shared;

public class Item : Entity
{
    [Required]
    public virtual Group Group { get; set; }
    
    [Required]
    public virtual string Value { get; set; }
}
