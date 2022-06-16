using System.ComponentModel.DataAnnotations;

namespace VerifyDB.Requests;

public sealed class UserRegisterRequest
{
    [Required, EmailAddress]
    public string Email { get; set; }
    [Required,MinLength(6, ErrorMessage = "Please enter a least 6 characters")]
    public string Password { get; set; }
    
    [Required, Compare("Password")]
    public string ConfirmPassword { get; set; }
}