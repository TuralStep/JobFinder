using Microsoft.EntityFrameworkCore;

namespace Persistance.Contexts;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) {}




}
