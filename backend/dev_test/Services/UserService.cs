using dev_test.DTOs;
using dev_test.Repositories.Contracts;
using dev_test.Services.Contracts;

namespace dev_test.Services
{
    public class UserService : IUserService
    {
        public IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public IEnumerable<User> GetUsers()
        {
            return _userRepository.GetUsers();
        }

        public void PostUser(User user)
        {
            _userRepository.PostUser(user);
        }
    }
}
