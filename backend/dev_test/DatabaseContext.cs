using dev_test.Entities;
using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore;
//using System.Data.Entity;

namespace dev_test
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options){}
        public DbSet<User> Users { get; set; }
        public DbSet<Survey> Surveys { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<Answer> Answers { get; set; }
        public virtual DbSet<Invitation> Invitations { get; set; }
        public virtual DbSet<Submission> Submissions { get; set; }
        public virtual DbSet<SubmissionDetail> SubmissionDetails { get; set; }
    }
}

