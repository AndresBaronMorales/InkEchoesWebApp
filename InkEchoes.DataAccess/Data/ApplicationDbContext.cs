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

            // Add data
            modelBuilder.Entity<Language>().HasData(
                new Language { LanguageId = 1, LanguageName = "Spanish" },
                new Language { LanguageId = 2, LanguageName = "French" },
                new Language { LanguageId = 3, LanguageName = "German" },
                new Language { LanguageId = 4, LanguageName = "Italian" },
                new Language { LanguageId = 5, LanguageName = "English" },
                new Language { LanguageId = 6, LanguageName = "Swedish" }
            );

            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Science Fiction" },
                new Category { CategoryId = 2, CategoryName = "Fantasy" },
                new Category { CategoryId = 3, CategoryName = "Mystery" },
                new Category { CategoryId = 4, CategoryName = "Romance" },
                new Category { CategoryId = 5, CategoryName = "Thriller" },
                new Category { CategoryId = 6, CategoryName = "Non-Fiction" },
                new Category { CategoryId = 7, CategoryName = "" },
                new Category { CategoryId = 8, CategoryName = "Biography" },
                new Category { CategoryId = 9, CategoryName = "Horror" },
                new Category { CategoryId = 10, CategoryName = "Self-Help" },
                new Category { CategoryId = 11, CategoryName = "Magical Realism" },
                new Category { CategoryId = 12, CategoryName = "Fiction" },
                new Category { CategoryId = 13, CategoryName = "Young Adult" },
                new Category { CategoryId = 14, CategoryName = "Classic" },
                new Category { CategoryId = 14, CategoryName = "Contemporary" }
            );

            modelBuilder.Entity<BookCategory>().HasData(
                new BookCategory { BookCategoryId = 1, BookId = "e7021c6d-e793-42d3-b912-0d39faa7c111", CategoryId = 2 },
                new BookCategory { BookCategoryId = 2, BookId = "e7021c6d-e793-42d3-b912-0d39faa7c111", CategoryId = 12 },
                new BookCategory { BookCategoryId = 3, BookId = "e7021c6d-e793-42d3-b912-0d39faa7c111", CategoryId = 13 },
                new BookCategory { BookCategoryId = 4, BookId = "f40f905f-5b5b-412f-a191-0fee276f44a8", CategoryId = 1 },
                new BookCategory { BookCategoryId = 5, BookId = "f40f905f-5b5b-412f-a191-0fee276f44a8", CategoryId = 12 },
                new BookCategory { BookCategoryId = 6, BookId = "f40f905f-5b5b-412f-a191-0fee276f44a8", CategoryId = 14 },
                new BookCategory { BookCategoryId = 7, BookId = "953fc395-3d0c-449b-88bd-ad7f8b52a9d6", CategoryId = 2 },
                new BookCategory { BookCategoryId = 8, BookId = "953fc395-3d0c-449b-88bd-ad7f8b52a9d6", CategoryId = 12 },
                new BookCategory { BookCategoryId = 9, BookId = "953fc395-3d0c-449b-88bd-ad7f8b52a9d6", CategoryId = 14 },
                new BookCategory { BookCategoryId = 10, BookId = "44c65b5c-1010-4ad0-8483-f19b70007c55", CategoryId = 12 },
                new BookCategory { BookCategoryId = 11, BookId = "44c65b5c-1010-4ad0-8483-f19b70007c55", CategoryId = 14 },
                new BookCategory { BookCategoryId = 12, BookId = "3369e2b3-4149-481d-ac47-1873bf4ee25c", CategoryId = 12 },
                new BookCategory { BookCategoryId = 13, BookId = "3369e2b3-4149-481d-ac47-1873bf4ee25c", CategoryId = 14 },
                new BookCategory { BookCategoryId = 14, BookId = "009f9fff-a198-4f37-9824-cf3ad243bb3b", CategoryId = 4 },
                new BookCategory { BookCategoryId = 15, BookId = "009f9fff-a198-4f37-9824-cf3ad243bb3b", CategoryId = 12 },
                new BookCategory { BookCategoryId = 16, BookId = "009f9fff-a198-4f37-9824-cf3ad243bb3b", CategoryId = 14 },
                new BookCategory { BookCategoryId = 17, BookId = "ae4225b7-b2a9-4c64-982c-e8034c09a87c", CategoryId = 12 },
                new BookCategory { BookCategoryId = 18, BookId = "ae4225b7-b2a9-4c64-982c-e8034c09a87c", CategoryId = 13 },
                new BookCategory { BookCategoryId = 19, BookId = "eb0cf1f2-7d8c-4f23-b69c-381363e608fc", CategoryId = 12 },
                new BookCategory { BookCategoryId = 20, BookId = "eb0cf1f2-7d8c-4f23-b69c-381363e608fc", CategoryId = 14 },
                new BookCategory { BookCategoryId = 21, BookId = "a1a80417-3c02-44e4-abb2-d4f04b646c39", CategoryId = 12 },
                new BookCategory { BookCategoryId = 22, BookId = "a1a80417-3c02-44e4-abb2-d4f04b646c39", CategoryId = 14 },
                new BookCategory { BookCategoryId = 23, BookId = "4325482a-137b-42e6-9216-3c2c3ab4cd09", CategoryId = 12 },
                new BookCategory { BookCategoryId = 24, BookId = "4325482a-137b-42e6-9216-3c2c3ab4cd09", CategoryId = 15 },
                new BookCategory { BookCategoryId = 25, BookId = "bcb5111b-df8f-473a-a068-ca073df31a9e", CategoryId = 2 },
                new BookCategory { BookCategoryId = 26, BookId = "0e89473b-ab23-43d8-b887-0936f1108413", CategoryId = 3 },
                new BookCategory { BookCategoryId = 27, BookId = "0e89473b-ab23-43d8-b887-0936f1108413", CategoryId = 5 },
                new BookCategory { BookCategoryId = 28, BookId = , CategoryId = },
                new BookCategory { BookCategoryId = 29, BookId = , CategoryId = },
                new BookCategory { BookCategoryId = 30, BookId = , CategoryId = },
                new BookCategory { BookCategoryId = 31, BookId = , CategoryId = },
                new BookCategory { BookCategoryId = 32, BookId = , CategoryId = },
                new BookCategory { BookCategoryId = 33, BookId = , CategoryId = },
                new BookCategory { BookCategoryId = 34, BookId = , CategoryId = },
                new BookCategory { BookCategoryId = 35, BookId = , CategoryId = },
                new BookCategory { BookCategoryId = 36, BookId = , CategoryId = },
                new BookCategory { BookCategoryId = 37, BookId = , CategoryId = },
                new BookCategory { BookCategoryId = 38, BookId = , CategoryId = },
                new BookCategory { BookCategoryId = 39, BookId = , CategoryId = },


            );

            modelBuilder.Entity<Genre>().HasData(
                new Genre { GenreId = 1, GenreName = "Adventure" },
                new Genre { GenreId = 2, GenreName = "Drama" },
                new Genre { GenreId = 3, GenreName = "Comedy" },
                new Genre { GenreId = 4, GenreName = "Crime" },
                new Genre { GenreId = 5, GenreName = "Historical" },
                new Genre { GenreId = 6, GenreName = "Horror" },
                new Genre { GenreId = 7, GenreName = "Dystopian" },
                new Genre { GenreId = 8, GenreName = "Tragedy" }
            );

            modelBuilder.Entity<Author>().HasData(
                new Author { AuthorId = 1, Name = "J.K. Rowling", Nacionality = "England" },
                new Author { AuthorId = 2, Name = "George Orwell", Nacionality = "Eastern India" },
                new Author { AuthorId = 3, Name = "J.R.R. Tolkien", Nacionality = "South Africa" },
                new Author { AuthorId = 4, Name = "Harper Lee", Nacionality = "U.S.A" },
                new Author { AuthorId = 5, Name = "F. Scott Fitzgerald", Nacionality = "U.S.A" },
                new Author { AuthorId = 6, Name = "Jane Austen", Nacionality = "England" },
                new Author { AuthorId = 7, Name = "Markus Zusak", Nacionality = "Australia" },
                new Author { AuthorId = 8, Name = "Ernest Hemingway", Nacionality = "U.S.A" },
                new Author { AuthorId = 9, Name = "Gabriel García Márquez", Nacionality = "Colombia" },
                new Author { AuthorId = 10, Name = "Chimamanda Ngozi Adichie", Nacionality = "Nigeria" },
                new Author { AuthorId = 11, Name = "Terry Pratchett", Nacionality = "England" },
                new Author { AuthorId = 12, Name = "Neil Gaiman", Nacionality = "England" },
                new Author { AuthorId = 13, Name = "Stieg Larsson", Nacionality = "Swedish" }
            );



            modelBuilder.Entity<Book>().HasData(
                new Book
                {
                    BookId = "e7021c6d-e793-42d3-b912-0d39faa7c111",
                    Title = "Harry Potter and the Sorcerer's Stone",
                    ISBN = "978-0439708180",
                    Description = "A young boy discovers he is a wizard on his 11th birthday.",
                    NumberPages = 320,
                    Origin = "United Kingdom",
                    Editorial = "Scholastic",
                    Price = 19
                },
                new Book
                {
                    BookId = "f40f905f-5b5b-412f-a191-0fee276f44a8",
                    Title = "1984",
                    ISBN = "978-0451524935",
                    Description = "A dystopian novel set in a totalitarian society under constant surveillance.",
                    NumberPages = 328,
                    Origin = "United Kingdom",
                    Editorial = "Signet Classic",
                    Price = 99
                },
                new Book
                {
                    BookId = "953fc395-3d0c-449b-88bd-ad7f8b52a9d6",
                    Title = "The Hobbit",
                    ISBN = "978-0345339683",
                    Description = "The adventure of Bilbo Baggins as he goes on a quest to reclaim a treasure.",
                    NumberPages = 320,
                    Origin = "United Kingdom",
                    Editorial = "Del Rey",
                    Price = 89
                },
                new Book
                {
                    BookId = "44c65b5c-1010-4ad0-8483-f19b70007c55",
                    Title = "To Kill a Mockingbird",
                    ISBN = "978-0060935467",
                    Description = "A novel about the serious issues of rape and racial inequality.",
                    NumberPages = 336,
                    Origin = "United States",
                    Editorial = "Harper Perennial Modern Classics",
                    Price = 149
                },
                new Book
                {
                    BookId = "3369e2b3-4149-481d-ac47-1873bf4ee25c",
                    Title = "The Great Gatsby",
                    ISBN = "978-0743273565",
                    Description = "A novel about the American dream and the Roaring Twenties.",
                    NumberPages = 180,
                    Origin = "United States",
                    Editorial = "Scribner",
                    Price = 109
                },
                new Book
                {
                    BookId = "009f9fff-a198-4f37-9824-cf3ad243bb3b",
                    Title = "Pride and Prejudice",
                    ISBN = "978-1503290563",
                    Description = "A romantic novel that also critiques the British landed gentry.",
                    NumberPages = 278,
                    Origin = "United Kingdom",
                    Editorial = "CreateSpace Independent Publishing Platform",
                    Price = 79
                },
                new Book
                {
                    BookId = "ae4225b7-b2a9-4c64-982c-e8034c09a87c",
                    Title = "The Book Thief",
                    ISBN = "978-0375842207",
                    Description = "A story narrated by Death, about a young girl's life in Nazi Germany.",
                    NumberPages = 552,
                    Origin = "Australia",
                    Editorial = "Knopf Books for Young Readers",
                    Price = 129
                },
                new Book
                {
                    BookId = "eb0cf1f2-7d8c-4f23-b69c-381363e608fc",
                    Title = "The Old Man and the Sea",
                    ISBN = "978-0684830490",
                    Description = "The story of an aging fisherman and his struggle with a giant marlin.",
                    NumberPages = 128,
                    Origin = "United States",
                    Editorial = "Scribner",
                    Price = 89
                },
                new Book
                {
                    BookId = "a1a80417-3c02-44e4-abb2-d4f04b646c39",
                    Title = "One Hundred Years of Solitude",
                    ISBN = "978-0060883287",
                    Description = "The multi-generational story of the Buendía family in the town of Macondo.",
                    NumberPages = 417,
                    Origin = "Colombia",
                    Editorial = "Harper Perennial Modern Classics",
                    Price = 189
                },
                new Book
                {
                    BookId = "4325482a-137b-42e6-9216-3c2c3ab4cd09",
                    Title = "Half of a Yellow Sun",
                    ISBN = "978-1400095209",
                    Description = "A novel about the Nigerian Civil War through the perspectives of three characters.",
                    NumberPages = 560,
                    Origin = "Nigeria",
                    Editorial = "Anchor",
                    Price = 169
                },
                new Book
                {
                    BookId = "bcb5111b-df8f-473a-a068-ca073df31a9e",
                    Title = "Good Omens: The Nice and Accurate Prophecies of Agnes Nutter, Witch",
                    ISBN = "978-0060853983",
                    Description = "The story of an angel and a demon who team up to prevent the apocalypse.",
                    NumberPages = 432,
                    Origin = "United Kingdom",
                    Editorial = "HarperTorch",
                    Price = 14
                },
                new Book
                {
                    BookId = "0e89473b-ab23-43d8-b887-0936f1108413",
                    Title = "The Girl with the Dragon Tattoo",
                    ISBN = "978-0307454546",
                    Description = "A journalist and a hacker team up to solve a decades-old disappearance.",
                    NumberPages = 465,
                    Origin = "Sweden",
                    Editorial = "Vintage Crime/Black Lizard",
                    Price = 159
                }
            );

            modelBuilder.Entity<BooksAuthors>().HasData(
                new BooksAuthors { BooksAuthorsId = 1, BookId = "e7021c6d-e793-42d3-b912-0d39faa7c111", AuthorId = 1 },
                new BooksAuthors { BooksAuthorsId = 2, BookId = "f40f905f-5b5b-412f-a191-0fee276f44a8", AuthorId = 2 },
                new BooksAuthors { BooksAuthorsId = 3, BookId = "953fc395-3d0c-449b-88bd-ad7f8b52a9d6", AuthorId = 3 },
                new BooksAuthors { BooksAuthorsId = 4, BookId = "44c65b5c-1010-4ad0-8483-f19b70007c55", AuthorId = 4 },
                new BooksAuthors { BooksAuthorsId = 5, BookId = "3369e2b3-4149-481d-ac47-1873bf4ee25c", AuthorId = 5 },
                new BooksAuthors { BooksAuthorsId = 6, BookId = "009f9fff-a198-4f37-9824-cf3ad243bb3b", AuthorId = 6 },
                new BooksAuthors { BooksAuthorsId = 7, BookId = "ae4225b7-b2a9-4c64-982c-e8034c09a87c", AuthorId = 7 },
                new BooksAuthors { BooksAuthorsId = 8, BookId = "eb0cf1f2-7d8c-4f23-b69c-381363e608fc", AuthorId = 8 },
                new BooksAuthors { BooksAuthorsId = 9, BookId = "a1a80417-3c02-44e4-abb2-d4f04b646c39", AuthorId = 9 },
                new BooksAuthors { BooksAuthorsId = 10, BookId = "4325482a-137b-42e6-9216-3c2c3ab4cd09", AuthorId = 10 },
                new BooksAuthors { BooksAuthorsId = 11, BookId = "bcb5111b-df8f-473a-a068-ca073df31a9e", AuthorId = 11 },
                new BooksAuthors { BooksAuthorsId = 12, BookId = "bcb5111b-df8f-473a-a068-ca073df31a9e", AuthorId = 12 },
                new BooksAuthors { BooksAuthorsId = 13, BookId = "0e89473b-ab23-43d8-b887-0936f1108413", AuthorId = 13 }
            );

            modelBuilder.Entity<BookGenre>().HasData(
                new BookGenre { BookGenreId = 1, BookId = "e7021c6d-e793-42d3-b912-0d39faa7c111", GenreId = 1 },
                new BookGenre { BookGenreId = 2, BookId = "f40f905f-5b5b-412f-a191-0fee276f44a8", GenreId = 7 },
                new BookGenre { BookGenreId = 3, BookId = "953fc395-3d0c-449b-88bd-ad7f8b52a9d6", GenreId = 1 },
                new BookGenre { BookGenreId = 4, BookId = "44c65b5c-1010-4ad0-8483-f19b70007c55", GenreId = 2 },
                new BookGenre { BookGenreId = 5, BookId = "44c65b5c-1010-4ad0-8483-f19b70007c55", GenreId = 5 },
                new BookGenre { BookGenreId = 6, BookId = "3369e2b3-4149-481d-ac47-1873bf4ee25c", GenreId = 2 },
                new BookGenre { BookGenreId = 7, BookId = "3369e2b3-4149-481d-ac47-1873bf4ee25c", GenreId = 8 },
                new BookGenre { BookGenreId = 8, BookId = "009f9fff-a198-4f37-9824-cf3ad243bb3b", GenreId = 2 },
                new BookGenre { BookGenreId = 9, BookId = "ae4225b7-b2a9-4c64-982c-e8034c09a87c", GenreId = 2 },
                new BookGenre { BookGenreId = 10, BookId = "ae4225b7-b2a9-4c64-982c-e8034c09a87c", GenreId = 5 },
                new BookGenre { BookGenreId = 11, BookId = "eb0cf1f2-7d8c-4f23-b69c-381363e608fc", GenreId = 1 },
                new BookGenre { BookGenreId = 12, BookId = "eb0cf1f2-7d8c-4f23-b69c-381363e608fc", GenreId = 2 },
                new BookGenre { BookGenreId = 13, BookId = "a1a80417-3c02-44e4-abb2-d4f04b646c39", GenreId = 5 },
                new BookGenre { BookGenreId = 14, BookId = "a1a80417-3c02-44e4-abb2-d4f04b646c39", GenreId = 11 },
                new BookGenre { BookGenreId = 15, BookId = "4325482a-137b-42e6-9216-3c2c3ab4cd09", GenreId = 5 },
                new BookGenre { BookGenreId = 16, BookId = "4325482a-137b-42e6-9216-3c2c3ab4cd09", GenreId = 2 },
                new BookGenre { BookGenreId = 17, BookId = "bcb5111b-df8f-473a-a068-ca073df31a9e", GenreId = 6 },
                new BookGenre { BookGenreId = 18, BookId = "bcb5111b-df8f-473a-a068-ca073df31a9e", GenreId = 3 },
                new BookGenre { BookGenreId = 19, BookId = "0e89473b-ab23-43d8-b887-0936f1108413", GenreId = 4 }
            );













        }

    }
}
