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
        public string? Username { get; set; } 
        [Required]
        public string? Email { get; set; } 
        [Required]
        public string? Password { get; set; } 
        public string Role { get; set; } = "User";
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

    }
}