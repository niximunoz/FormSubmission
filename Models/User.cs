#pragma warning disable CS8618

using System.ComponentModel.DataAnnotations;
namespace FormSubmission.Models;
public class User
{
    [Required]
    [MinLength(4, ErrorMessage = "El campo debe contener al menos 4 caracteres.")]
    public string FirstName { get; set; }

    [Required]
    [MinLength(4, ErrorMessage = "El campo debe contener al menos 4 caracteres.")]
    public string LastName { get; set; }

    [Required]
    [Range(0, int.MaxValue)]
    public int Age { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    [MinLength(8, ErrorMessage = "La contraseña debe tener al menos 8 caracteres.")]
    public string Password { get; set; }
}