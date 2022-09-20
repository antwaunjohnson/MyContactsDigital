﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyContactsDigital.Models;

public class AppUser : IdentityUser
{
    [Required]
    [Display(Name = "First Name")]
    [StringLength(50,ErrorMessage = "The {0} must be at least {2} and a max of {1} characters long", MinimumLength = 2)]
    public string? FirstName { get; set; }

    [Required]
    [Display(Name = "Last Name")]
    [StringLength(50, ErrorMessage = "The {0} must be at least {2} and a max of {1} characters long", MinimumLength = 2)]
    public string? LastName { get; set; }

    [NotMapped]
    public string? FullName { get { return $"{FirstName} {LastName}"; } }

    public virtual ICollection<Contact>? Contacts { get; set; }
    public virtual ICollection<Category>? Categories { get; set; }
}
