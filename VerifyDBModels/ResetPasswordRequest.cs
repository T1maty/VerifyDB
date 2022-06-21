using System.ComponentModel.DataAnnotations;

namespace VerifyDB.Requests;

public sealed class ResetPasswordRequest
{
    [Required]
    public string Token { get; set; }
    [Required, MinLength(6, ErrorMessage = "Please enter a least 6 characters")]
    
    public string Password { get; set; }
    
    [Required, Compare("Password")]
    public string ConfirmPassword { get; set; }
}