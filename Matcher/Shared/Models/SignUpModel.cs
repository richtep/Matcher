using System.ComponentModel.DataAnnotations;

namespace Matcher.Shared.Models;

public class SignUpModel 
{
    [Required]
    public string Email { get; set; }

    /*
    [Required]
    public string Password { get; set; }
    
    [CompareProperty("Password", ErrorMessage = "Passwords must be the same.")]
    public string Confirm { get; set; }
    */

    public string NickName { get; set; }

   // public string LastName { get; set; }
}

