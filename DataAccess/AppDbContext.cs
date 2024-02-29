using Microsoft.EntityFrameworkCore;
using PlatformService.Models;

namespace PlatformService.DataAccess;

public class AppDbContext : DbContext
{
    public DbSet<Platform> Platforms { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
}