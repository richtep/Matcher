using System.ComponentModel.DataAnnotations;
using EntitySystem.Shared.Fluent.Domain;

namespace Matcher.Shared.Domain;

public class User : Entity
{
    public virtual string Nick { get; set; }

    [Required]
    public virtual string Email { get; set; }

    /*
    [Required]
    public virtual string Password { get; set; }
    */
}
