using EntitySystem.Shared.Fluent.Domain;
using System.ComponentModel.DataAnnotations;

namespace Matcher.Shared;

public class Game : Entity
{
    [Required]
    public virtual User User { get; set; }
        
}
