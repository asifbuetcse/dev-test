using dev_test.DTOs;
using System.Linq;

namespace dev_test.Repositories.Contracts
{
    public class UserRepository : IUserRepository
    {
        public DatabaseContext _databaseContext;
        public UserRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public IEnumerable<User> GetUsers()
        {
            _databaseContext.Database.EnsureCreated();
            return _databaseContext.User.ToList();
            //return new List<User>();
        }

        public void PostUser(User user)
        {
            _databaseContext.Add<User>(user);
            _databaseContext.SaveChanges();
        }
    }
}
