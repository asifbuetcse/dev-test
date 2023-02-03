using dev_test.Entities;
using System.Transactions;

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
            return _databaseContext.Users.ToList();
        }

        public void PostUser(User user)
        {
            using (var transaction = new TransactionScope())
            {
                try
                {
                    _databaseContext.Add(user);
                    _databaseContext.SaveChanges();
                    transaction.Complete();
                }
                catch (Exception)
                {
                    Transaction.Current.Rollback();
                    throw;
                }
            }

        }
    }
}
