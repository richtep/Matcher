using System.ComponentModel.DataAnnotations;
using EntitySystem.Shared.Fluent.Domain;

namespace Matcher.Shared.Domain;

public class Group : Entity
{
    [Required]
    public virtual Game Game {get; set;}

    public virtual bool Checked { get; set; } = true;
}