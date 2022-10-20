using System.ComponentModel.DataAnnotations;

namespace Matcher.Shared.Models;

public class DeleteGameModel 
{
    [Required]
    public string Password { get; set; }

    [Required]
    public string GameName { get; set; }

}

