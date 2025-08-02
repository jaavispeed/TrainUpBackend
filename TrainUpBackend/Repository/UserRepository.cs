

using TrainUpBackend.Models;
using TrainUpBackend.Models.Dtos;

namespace TrainUpBackend.Repository.IRepository
{
    public class UserRepository : IUserRepository
    {
        public readonly ApplicationDbContext _db;
        public UserRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public User? GetUserById(int id)
        {
            return _db.Users.FirstOrDefault(u => u.Id == id);
        }

        public ICollection<User> GetUsers()
        {
            return _db.Users.OrderBy(u => u.Username).ToList();
        }

        public bool IsUniqueUser(string username, string email)
        {
            return !_db.Users.Any(u => u.Username.ToLower().Trim() == username.ToLower().Trim());
        }

        public Task<UserLoginResponseDto> Login(UserLoginDto userLoginDto)
        {
            throw new NotImplementedException();
        }

        public Task<User> Register(CreateUserDto createUserDto)
        {
            throw new NotImplementedException();
        }
    }
}