using System.ComponentModel.DataAnnotations;

namespace Asp.Net.Identity.shared;

public class RegisterViewModel
{
    [Required]
    [StringLength(50)]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    [StringLength(50, MinimumLength = 8)]
    public string Password { get; set; }

    [Required]
    [StringLength(50, MinimumLength = 8)]
    public string ConfirmPassword { get; set; }
}
