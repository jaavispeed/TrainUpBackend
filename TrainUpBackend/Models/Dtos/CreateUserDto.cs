using System.ComponentModel.DataAnnotations;

namespace TrainUpBackend.Models.Dtos
{
    public class CreateUserDto
    {
        public string? Name { get; set; } 
        [Required(ErrorMessage = "El campo username es requerido")]
        public string Username { get; set; } = string.Empty;
        [Required(ErrorMessage = "El campo email es requerido")]
        public string Email { get; set; } = string.Empty;
        [Required(ErrorMessage = "El campo password es requerido")]
        public string? Password { get; set; } 
        [Required(ErrorMessage = "El campo role es requerido")]
        public string? Role { get; set; }
    }

}
