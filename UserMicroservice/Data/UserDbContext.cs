using Microsoft.EntityFrameworkCore;
using System.Reflection;
using UserMicroservice.Entities.Abstract;
using UserMicroservice.Entities.Concrete;

namespace UserMicroservice.Data
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> options)
        : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<BaseRole> Roles { get; set; }

    }
}
