using EntitySystem.Shared.Fluent.Domain;
using System.ComponentModel.DataAnnotations;

namespace Matcher.Shared;

public class ItemStatus
{
    [Required]
    public long Id { get; set; }

    [Required]
    public  Group Group { get; set; }
    
    [Required]
    public  string Value { get; set; }
    [Required]
    public  int Status { get; set; }
}


