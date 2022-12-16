using System.ComponentModel.DataAnnotations;
using Matcher.Shared.Domain;

namespace Matcher.Shared.Models;

public class ItemStatusModel 
{
    [Required]
    public  int State { get; set; }

    public int RoundNo { get; set; }
    
    [Required]
    public Item Item { get; set; }
}