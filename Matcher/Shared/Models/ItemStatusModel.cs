using System.ComponentModel.DataAnnotations;
using Matcher.Shared.Domain;

namespace Matcher.Shared.Models;

public class ItemStatusModel
{
    [Required]
    public long Id { get; set; }

    [Required]
    public  Group Group { get; set; }
    
    [Required]
    public  string Value { get; set; }
    [Required]
    public  int Status { get; set; }

    public int RoundNo { get; set; }
}


