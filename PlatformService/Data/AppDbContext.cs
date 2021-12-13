using Microsoft.EntityFrameworkCore;
using PlaformService.Models;

namespace PlatformService.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> dbContextOptions) : base(dbContextOptions)
    {

    }

    public DbSet<Platform> Platforms { get; set; }

}