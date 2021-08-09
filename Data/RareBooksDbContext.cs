namespace RareBooks.Data
{
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using RareBooks.Data.Models;

    public class RareBooksDbContext : IdentityDbContext
    {
        public RareBooksDbContext(DbContextOptions<RareBooksDbContext> options)
            : base(options)
        {
        }
        public DbSet<Book> Books { get; init; }
        public DbSet<Genre> Categories { get; init; }
    }
}
