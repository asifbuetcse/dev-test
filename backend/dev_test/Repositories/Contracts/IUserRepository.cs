using dev_test.Entities;
namespace dev_test.Repositories.Contracts
{
    public interface IUserRepository
    {
        public IEnumerable<User> GetUsers();
        public void PostUser(User user);
    }
}
