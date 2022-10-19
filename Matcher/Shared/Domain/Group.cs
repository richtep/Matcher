using System.ComponentModel.DataAnnotations;
using EntitySystem.Shared.Fluent.Domain;

namespace Matcher.Shared.Domain;

public class Group : Entity
{
 
    [Required]
    public virtual Game Game {get; set;}

    /*
    public virtual string Name { get; set; }
        
    public static readonly Initial Reference = new();

    public class Holder : Holder<Group>
    {
        public Group Home { get; set; } = new() { Name = "Home" };

        public Group Work { get; set; } = new() { Name = "Work" };
    }

    public class Initial : Initial<Holder, Group>
    {
        public Initial() : base(
            h => h.Home,
            h => h.Work)
        {
        }
    }
    */
}
