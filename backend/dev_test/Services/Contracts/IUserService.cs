using dev_test.DTOs;

namespace dev_test.Services.Contracts
{
    public interface IUserService
    {
        public IEnumerable<User> GetUsers();
        public void PostUser(User user);
    }
}
