using System.ComponentModel.DataAnnotations;

namespace Matcher.Shared.Models;

public class DeleteGameModel 
{
    [Required]
    public long GameId { get; set; }


    [Required]
    public string Password { get; set; }
}

