using PlaformService.Models;

namespace PlatformService.Data;

public static class PrepareDb
{
    public static void PreparePopulation(IApplicationBuilder app)
    {
        using var serviceScope = app.ApplicationServices.CreateScope();
        SeedData(serviceScope.ServiceProvider.GetService<AppDbContext>());
    }

    private static void SeedData(AppDbContext context)
    {
        if (!context.Platforms.Any())
        {
            Console.WriteLine("Seeding data");
            context.Platforms.AddRange(
                new Platform() { Name = "Dot Net", Publisher = "Microsoft", Cost = "Free", Id = 1},
                new Platform() { Name = "Docker", Publisher = "Docker", Cost = "Free", Id = 2},
                new Platform() { Name = "Kubernetes", Publisher = "Cloud native", Cost = "Free", Id = 3}
            );

            context.SaveChanges();
        }
        else
        {
            Console.WriteLine("We already have data");
        }
    }
}
