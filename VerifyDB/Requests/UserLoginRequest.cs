using System.ComponentModel.DataAnnotations;

namespace VerifyDB.Requests;

public sealed class UserLoginRequest
{
    [Required, EmailAddress]
    public string Email { get; set; }
    
    [Required]
    public string Password { get; set; }
}