using dev_test.DTOs;

namespace dev_test.Repositories.Contracts
{
    public interface IUserRepository
    {
        public IEnumerable<User> GetUsers();
        public void PostUser(User user);
    }
}
