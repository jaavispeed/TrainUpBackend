namespace TrainUpBackend.Models.Dtos
{
    public class UserLoginResponseDto
    {
        public UserRegisterUserDto? User { get; set; }
        public string? Token { get; set; }
        public string? Message { get; set; }
    }
}
