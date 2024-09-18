using Domain.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Persistance.Contexts;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) {}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(modelBuilder);
    }

    

    public virtual DbSet<Vacancy> Vacancies { get; set; }
    public virtual DbSet<Company> Companies { get; set; }
    public virtual DbSet<Category> Categories { get; set; }


}
