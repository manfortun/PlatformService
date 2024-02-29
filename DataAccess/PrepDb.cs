using PlatformService.Models;

namespace PlatformService.DataAccess;

public static class PrepDb
{
    public static void Populate(this IApplicationBuilder app)
    {
        using(var serviceScope = app.ApplicationServices.CreateScope())
        {
            serviceScope.ServiceProvider.GetService<AppDbContext>()?.SeedData();
        }
    }

    private static void SeedData(this AppDbContext context)
    {
        if (!context.Platforms.Any())
        {
            Console.WriteLine($"Seeding data into {nameof(context.Platforms)}...");

            context.Platforms.AddRange(
                new Platform() { Name = "DotNet", Publisher = "Microsoft", Cost = "Free" },
                new Platform() { Name = "SQL Server Express", Publisher = "Microsoft", Cost = "Free" },
                new Platform() { Name = "Kubernetes", Publisher = "Cloud Native Computing Foundaation", Cost = "Free" }
            );

            context.SaveChanges();
        }
    }
}
