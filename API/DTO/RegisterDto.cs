using System;
using System.ComponentModel.DataAnnotations;

namespace API.DTO;

public class RegisterDto
{
    [Required]
    public required string Username {get; set;} = string.Empty;
    [Required]
    [StringLength(8, MinimumLength =4)]
    public required string Password {get; set;} = string.Empty;
}
