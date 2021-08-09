
namespace RareBooks.Infrastructure
{
    using RareBooks.Data;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;
    using System.Linq;
    using RareBooks.Data.Models;

    public static class ApplicatonBuilderExtensions
    {
        public static IApplicationBuilder PrepareDatabase(
           this IApplicationBuilder app)
        {
            using var scopedServices = app.ApplicationServices.CreateScope();

            var data = scopedServices.ServiceProvider.GetService<RareBooksDbContext>();

            data.Database.Migrate();

            SeedCategories(data);

            return app;
        }

        private static void SeedCategories(RareBooksDbContext data)
        {
            if (data.Categories.Any())
            {
                return;
            }

            data.Categories.AddRange(new[]
            {
                new Genre{Name = "Mistery"},
                new Genre{Name = "Horror"},
                new Genre{Name = "Thriller"},
                new Genre{Name = "Fantasy"},
                new Genre{Name = "Romance"},
                new Genre{Name = "Biography"},
                new Genre{Name = "History"},
                new Genre{Name = "Children’s"},
                new Genre{Name = "Science & Technology’s"},
                new Genre{Name = "Action & Adventure"},
                new Genre{Name = "Graphic Novel"},
            });

            data.SaveChanges();
        }

    }
}
