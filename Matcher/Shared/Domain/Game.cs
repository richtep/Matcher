using System.ComponentModel.DataAnnotations;
using EntitySystem.Shared.Fluent.Domain;

namespace Matcher.Shared.Domain;

public class Game : Entity
{
    [Required]
    public virtual string Name { get; set; }
    [Required]
    public virtual User User { get; set; }

    public virtual bool Active { get; set; } = true;

    [Required]
    public virtual string Password { get; set; }
}
