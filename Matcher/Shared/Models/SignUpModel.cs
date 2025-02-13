﻿using System.ComponentModel.DataAnnotations;
using Matcher.Shared.Domain;

namespace Matcher.Shared.Models;

public class SignUpModel 
{
    [Required]
    public string Email { get; set; }

    [Required]
    public string GameName { get; set; }

    [Required]
    public string Password { get; set; }

    [Required]
    public long FolderId { get; set; }

    [CompareProperty("Password", ErrorMessage = "Passwords must be the same.")]
    public string Confirm { get; set; }
    

    public string NickName { get; set; }

    public bool Chemical { get; set; }

    public bool Unique { get; set; } = true;
}

