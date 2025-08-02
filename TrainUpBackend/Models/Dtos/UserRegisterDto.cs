
namespace TrainUpBackend.Models.Dtos
{
    public class UserRegisterUserDto
    {
        public string? Id { get; set; }
        public required string Username { get; set; } 
        public required string Email { get; set; } 
        public required string Password { get; set; } 
        public string? Name { get; set; } 
        public string? Role { get; set; }

    }
}