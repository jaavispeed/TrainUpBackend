

using TrainUpBackend.Models;
using TrainUpBackend.Models.Dtos;

namespace TrainUpBackend.Repository.IRepository
{
    public interface IUserRepository
    {
        ICollection<User> GetUsers();
        User? GetUserById(int id);
        bool IsUniqueUser(string username, string email);
        Task<UserLoginResponseDto> Login(UserLoginDto userLoginDto);
        Task<User> Register(CreateUserDto createUserDto);
    }
}