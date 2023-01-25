using dev_test.DTOs;
using Microsoft.EntityFrameworkCore;

namespace dev_test
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options){}
        public DbSet<User> User { get; set; }
        public DbSet<Survey> Survey { get; set; }
        public DbSet<Question> Question { get; set; }
        public DbSet<Answer> Answer { get; set; }
    }
}

