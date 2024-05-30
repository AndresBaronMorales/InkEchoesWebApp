using InkEchoes.Models;
using Microsoft.EntityFrameworkCore;

namespace InkEchoes.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<BookImage> BookImages { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<BookLanguage> BooksLanguages { get; set; }
        public DbSet<BookCategory> BooksCategories { get; set; }
        public DbSet<BookGenre> BooksGenres { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Unique fields
            modelBuilder.Entity<Language>().HasIndex(l => l.LanguageName).IsUnique();
            modelBuilder.Entity<Category>().HasIndex(c => c.CategoryName).IsUnique();
            modelBuilder.Entity<Genre>().HasIndex(g => g.GenreName).IsUnique();
        }

    }
}
