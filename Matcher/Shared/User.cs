using EntitySystem.Shared.Fluent.Domain;
using System.ComponentModel.DataAnnotations;

namespace Matcher.Shared;

public class User : Entity
{
    public virtual string Nick { get; set; }

    [Required]
    public virtual string Email { get; set; }
    [Required]
    public virtual string Password { get; set; }
}
