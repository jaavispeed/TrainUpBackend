using System.ComponentModel.DataAnnotations;

namespace TrainUpBackend.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; } 
        [Required]
        public string Username { get; set; } = string.Empty;
        [Required]
        public string Email { get; set; } = string.Empty;
        [Required]
        public string? Password { get; set; } 
        public string? Role { get; set; }
    }
}