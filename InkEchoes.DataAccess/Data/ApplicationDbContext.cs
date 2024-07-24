using InkEchoes.Models;
using Microsoft.EntityFrameworkCore;

namespace InkEchoes.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<BookImage> BookImages { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<BooksAuthors> BooksAuthors { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<BookCategory> BooksCategories { get; set; }


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Unique fields
            modelBuilder.Entity<Category>().HasIndex(c => c.CategoryName).IsUnique();
            modelBuilder.Entity<Author>().HasIndex(a => a.Name).IsUnique();

            // Add data
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
                },
                new Book
                {
                    BookId = "03a9b093-fcbd-4c71-8d4c-8e68307884b8",
                    Title = "Dune",
                    ISBN = "978-0441013593",
                    Description = "A complex tale of politics, religion, and ecology on the desert planet Arrakis.",
                    NumberPages = 896,
                    Origin = "United States",
                    Editorial = "Ace",
                    Price = 179
                },
                new Book
                {
                    BookId = "58a645a5-e55a-40c9-b2e0-b1144f140840",
                    Title = "The Da Vinci Code",
                    ISBN = "978-0307474278",
                    Description = "A symbologist uncovers a secret society while investigating a murder at the Louvre.",
                    NumberPages = 689,
                    Origin = "United States",
                    Editorial = "Anchor",
                    Price = 149
                },
                new Book
                {
                    BookId = "f94aec15-cd4b-448f-9c57-01fa09d08ac4",
                    Title = "Sapiens: A Brief History of Humankind",
                    ISBN = "978-0062316097",
                    Description = "An exploration of the history and impact of Homo sapiens on the world.",
                    NumberPages = 498,
                    Origin = "Israel",
                    Editorial = "Harper",
                    Price = 185
                },
                new Book
                {
                    BookId = "f105484e-5f4b-4a9e-b659-b99cdc4ef2ba",
                    Title = "Steve Jobs",
                    ISBN = "978-1451648539",
                    Description = "The biography of Steve Jobs, detailing his life and career as a tech visionary.",
                    NumberPages = 656,
                    Origin = "United States",
                    Editorial = "Simon & Schuster",
                    Price = 179
                },
                new Book
                {
                    BookId = "afe2affa-c3a6-42d6-97ae-ae2bb32f6252",
                    Title = "The Shining",
                    ISBN = "978-0307743657",
                    Description = "A family becomes isolated in a haunted hotel during the winter.",
                    NumberPages = 688,
                    Origin = "United States",
                    Editorial = "Anchor",
                    Price = 149
                },
                new Book
                {
                    BookId = "ba599047-7bf3-43b5-b878-0443392a092d",
                    Title = "The Power of Habit: Why We Do What We Do in Life and Business",
                    ISBN = "978-0812981605",
                    Description = "An exploration of the science behind why habits exist and how they can be changed.",
                    NumberPages = 371,
                    Origin = "United States",
                    Editorial = "Random House",
                    Price = 169
                },
                new Book
                {
                    BookId = "cb1c497b-2822-4154-a876-23678c6406f2",
                    Title = "Gone Girl",
                    ISBN = "978-0307588371",
                    Description = "A thriller about a man suspected of causing his wife's disappearance.",
                    NumberPages = 432,
                    Origin = "United States",
                    Editorial = "Crown Publishing Group",
                    Price = 15
                }
            );

            modelBuilder.Entity<Author>().HasData(
                new Author { AuthorId = 1, Name = "J. K. Rowling", Nacionality = "England" },
                new Author { AuthorId = 2, Name = "George Orwell", Nacionality = "British India" },
                new Author { AuthorId = 3, Name = "J. R. R. Tolkien", Nacionality = "South Africa" },
                new Author { AuthorId = 4, Name = "Harper Lee", Nacionality = "U.S.A" },
                new Author { AuthorId = 5, Name = "F. Scott Fitzgerald", Nacionality = "U.S.A" },
                new Author { AuthorId = 6, Name = "Jane Austen", Nacionality = "England" },
                new Author { AuthorId = 7, Name = "Markus Zusak", Nacionality = "Australia" },
                new Author { AuthorId = 8, Name = "Ernest Hemingway", Nacionality = "U.S.A" },
                new Author { AuthorId = 9, Name = "Gabriel García Márquez", Nacionality = "Colombia" },
                new Author { AuthorId = 10, Name = "Chimamanda Ngozi Adichie", Nacionality = "Nigeria" },
                new Author { AuthorId = 11, Name = "Terry Pratchett", Nacionality = "England" },
                new Author { AuthorId = 12, Name = "Neil Gaiman", Nacionality = "England" },
                new Author { AuthorId = 13, Name = "Stieg Larsson", Nacionality = "Sweden" },
                new Author { AuthorId = 14, Name = "Frank Herbert", Nacionality = "U.S.A" },
                new Author { AuthorId = 15, Name = "Dan Brown", Nacionality = "U.S.A" },
                new Author { AuthorId = 16, Name = "Yuval Noah Harari", Nacionality = "Israel" },
                new Author { AuthorId = 17, Name = "Walter Isaacson", Nacionality = "U.S.A" },
                new Author { AuthorId = 18, Name = "Stephen King", Nacionality = "U.S.A" },
                new Author { AuthorId = 19, Name = "Charles Duhigg", Nacionality = "U.S.A" },
                new Author { AuthorId = 20, Name = "Gillian Flynn", Nacionality = "U.S.A" }
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
                new BooksAuthors { BooksAuthorsId = 13, BookId = "0e89473b-ab23-43d8-b887-0936f1108413", AuthorId = 13 },
                new BooksAuthors { BooksAuthorsId = 14, BookId = "03a9b093-fcbd-4c71-8d4c-8e68307884b8", AuthorId = 14 },
                new BooksAuthors { BooksAuthorsId = 15, BookId = "58a645a5-e55a-40c9-b2e0-b1144f140840", AuthorId = 15 },
                new BooksAuthors { BooksAuthorsId = 16, BookId = "f94aec15-cd4b-448f-9c57-01fa09d08ac4", AuthorId = 16 },
                new BooksAuthors { BooksAuthorsId = 17, BookId = "f105484e-5f4b-4a9e-b659-b99cdc4ef2ba", AuthorId = 17 },
                new BooksAuthors { BooksAuthorsId = 18, BookId = "afe2affa-c3a6-42d6-97ae-ae2bb32f6252", AuthorId = 18 },
                new BooksAuthors { BooksAuthorsId = 19, BookId = "ba599047-7bf3-43b5-b878-0443392a092d", AuthorId = 19 },
                new BooksAuthors { BooksAuthorsId = 20, BookId = "cb1c497b-2822-4154-a876-23678c6406f2", AuthorId = 20 }
            );

            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Science Fiction" },
                new Category { CategoryId = 2, CategoryName = "Fantasy" },
                new Category { CategoryId = 3, CategoryName = "Mystery" },
                new Category { CategoryId = 4, CategoryName = "Romance" },
                new Category { CategoryId = 5, CategoryName = "Thriller" },
                new Category { CategoryId = 6, CategoryName = "Non-Fiction" },
                new Category { CategoryId = 7, CategoryName = "Adventure" },
                new Category { CategoryId = 8, CategoryName = "Biography" },
                new Category { CategoryId = 9, CategoryName = "Horror" },
                new Category { CategoryId = 10, CategoryName = "Self-Help" },
                new Category { CategoryId = 11, CategoryName = "Magical Realism" },
                new Category { CategoryId = 12, CategoryName = "Fiction" },
                new Category { CategoryId = 13, CategoryName = "Young Adult" },
                new Category { CategoryId = 14, CategoryName = "Classic" },
                new Category { CategoryId = 15, CategoryName = "Drama" },
                new Category { CategoryId = 16, CategoryName = "Comedy" },
                new Category { CategoryId = 17, CategoryName = "Crime" },
                new Category { CategoryId = 18, CategoryName = "Historical" },
                new Category { CategoryId = 20, CategoryName = "Dystopian" },
                new Category { CategoryId = 21, CategoryName = "Tragedy" },
                new Category { CategoryId = 22, CategoryName = "Contemporary" },
                new Category { CategoryId = 23, CategoryName = "Detective Fiction" },
                new Category { CategoryId = 24, CategoryName = "Conspiracy" },
                new Category { CategoryId = 25, CategoryName = "Gothic" },
                new Category { CategoryId = 26, CategoryName = "Psychological" }
            );

            modelBuilder.Entity<BookCategory>().HasData(
                new BookCategory { BookCategoryId = 1, BookId = "e7021c6d-e793-42d3-b912-0d39faa7c111", CategoryId = 2 },
                new BookCategory { BookCategoryId = 2, BookId = "e7021c6d-e793-42d3-b912-0d39faa7c111", CategoryId = 7 },
                new BookCategory { BookCategoryId = 3, BookId = "e7021c6d-e793-42d3-b912-0d39faa7c111", CategoryId = 12 },
                new BookCategory { BookCategoryId = 4, BookId = "e7021c6d-e793-42d3-b912-0d39faa7c111", CategoryId = 13 },
                new BookCategory { BookCategoryId = 5, BookId = "f40f905f-5b5b-412f-a191-0fee276f44a8", CategoryId = 20 },
                new BookCategory { BookCategoryId = 6, BookId = "f40f905f-5b5b-412f-a191-0fee276f44a8", CategoryId = 1 },
                new BookCategory { BookCategoryId = 7, BookId = "f40f905f-5b5b-412f-a191-0fee276f44a8", CategoryId = 12 },
                new BookCategory { BookCategoryId = 8, BookId = "f40f905f-5b5b-412f-a191-0fee276f44a8", CategoryId = 14 },
                new BookCategory { BookCategoryId = 9, BookId = "953fc395-3d0c-449b-88bd-ad7f8b52a9d6", CategoryId = 2 },
                new BookCategory { BookCategoryId = 10, BookId = "953fc395-3d0c-449b-88bd-ad7f8b52a9d6", CategoryId = 7 },
                new BookCategory { BookCategoryId = 11, BookId = "953fc395-3d0c-449b-88bd-ad7f8b52a9d6", CategoryId = 12 },
                new BookCategory { BookCategoryId = 12, BookId = "953fc395-3d0c-449b-88bd-ad7f8b52a9d6", CategoryId = 14 },
                new BookCategory { BookCategoryId = 13, BookId = "44c65b5c-1010-4ad0-8483-f19b70007c55", CategoryId = 15 },
                new BookCategory { BookCategoryId = 14, BookId = "44c65b5c-1010-4ad0-8483-f19b70007c55", CategoryId = 18 },
                new BookCategory { BookCategoryId = 15, BookId = "44c65b5c-1010-4ad0-8483-f19b70007c55", CategoryId = 12 },
                new BookCategory { BookCategoryId = 16, BookId = "44c65b5c-1010-4ad0-8483-f19b70007c55", CategoryId = 14 },
                new BookCategory { BookCategoryId = 17, BookId = "3369e2b3-4149-481d-ac47-1873bf4ee25c", CategoryId = 15 },
                new BookCategory { BookCategoryId = 18, BookId = "3369e2b3-4149-481d-ac47-1873bf4ee25c", CategoryId = 21 },
                new BookCategory { BookCategoryId = 19, BookId = "3369e2b3-4149-481d-ac47-1873bf4ee25c", CategoryId = 12 },
                new BookCategory { BookCategoryId = 20, BookId = "3369e2b3-4149-481d-ac47-1873bf4ee25c", CategoryId = 14 },
                new BookCategory { BookCategoryId = 21, BookId = "009f9fff-a198-4f37-9824-cf3ad243bb3b", CategoryId = 4 },
                new BookCategory { BookCategoryId = 22, BookId = "009f9fff-a198-4f37-9824-cf3ad243bb3b", CategoryId = 15 },
                new BookCategory { BookCategoryId = 23, BookId = "009f9fff-a198-4f37-9824-cf3ad243bb3b", CategoryId = 12 },
                new BookCategory { BookCategoryId = 24, BookId = "009f9fff-a198-4f37-9824-cf3ad243bb3b", CategoryId = 14 },
                new BookCategory { BookCategoryId = 25, BookId = "ae4225b7-b2a9-4c64-982c-e8034c09a87c", CategoryId = 18 },
                new BookCategory { BookCategoryId = 26, BookId = "ae4225b7-b2a9-4c64-982c-e8034c09a87c", CategoryId = 15 },
                new BookCategory { BookCategoryId = 27, BookId = "ae4225b7-b2a9-4c64-982c-e8034c09a87c", CategoryId = 12 },
                new BookCategory { BookCategoryId = 28, BookId = "ae4225b7-b2a9-4c64-982c-e8034c09a87c", CategoryId = 13 },
                new BookCategory { BookCategoryId = 29, BookId = "eb0cf1f2-7d8c-4f23-b69c-381363e608fc", CategoryId = 7 },
                new BookCategory { BookCategoryId = 30, BookId = "eb0cf1f2-7d8c-4f23-b69c-381363e608fc", CategoryId = 15 },
                new BookCategory { BookCategoryId = 31, BookId = "eb0cf1f2-7d8c-4f23-b69c-381363e608fc", CategoryId = 12 },
                new BookCategory { BookCategoryId = 32, BookId = "eb0cf1f2-7d8c-4f23-b69c-381363e608fc", CategoryId = 14 },
                new BookCategory { BookCategoryId = 33, BookId = "a1a80417-3c02-44e4-abb2-d4f04b646c39", CategoryId = 11 },
                new BookCategory { BookCategoryId = 34, BookId = "a1a80417-3c02-44e4-abb2-d4f04b646c39", CategoryId = 18 },
                new BookCategory { BookCategoryId = 35, BookId = "a1a80417-3c02-44e4-abb2-d4f04b646c39", CategoryId = 12 },
                new BookCategory { BookCategoryId = 36, BookId = "a1a80417-3c02-44e4-abb2-d4f04b646c39", CategoryId = 14 },
                new BookCategory { BookCategoryId = 37, BookId = "4325482a-137b-42e6-9216-3c2c3ab4cd09", CategoryId = 18 },
                new BookCategory { BookCategoryId = 38, BookId = "4325482a-137b-42e6-9216-3c2c3ab4cd09", CategoryId = 15 },
                new BookCategory { BookCategoryId = 39, BookId = "4325482a-137b-42e6-9216-3c2c3ab4cd09", CategoryId = 12 },
                new BookCategory { BookCategoryId = 40, BookId = "4325482a-137b-42e6-9216-3c2c3ab4cd09", CategoryId = 22 },
                new BookCategory { BookCategoryId = 41, BookId = "bcb5111b-df8f-473a-a068-ca073df31a9e", CategoryId = 9 },
                new BookCategory { BookCategoryId = 42, BookId = "bcb5111b-df8f-473a-a068-ca073df31a9e", CategoryId = 2 },
                new BookCategory { BookCategoryId = 43, BookId = "bcb5111b-df8f-473a-a068-ca073df31a9e", CategoryId = 16 },
                new BookCategory { BookCategoryId = 44, BookId = "0e89473b-ab23-43d8-b887-0936f1108413", CategoryId = 5 },
                new BookCategory { BookCategoryId = 45, BookId = "03a9b093-fcbd-4c71-8d4c-8e68307884b8", CategoryId = 1 },
                new BookCategory { BookCategoryId = 46, BookId = "58a645a5-e55a-40c9-b2e0-b1144f140840", CategoryId = 3 },
                new BookCategory { BookCategoryId = 47, BookId = "58a645a5-e55a-40c9-b2e0-b1144f140840", CategoryId = 23 },
                new BookCategory { BookCategoryId = 48, BookId = "58a645a5-e55a-40c9-b2e0-b1144f140840", CategoryId = 24 },
                new BookCategory { BookCategoryId = 49, BookId = "58a645a5-e55a-40c9-b2e0-b1144f140840", CategoryId = 5 },
                new BookCategory { BookCategoryId = 50, BookId = "f94aec15-cd4b-448f-9c57-01fa09d08ac4", CategoryId = 6 },
                new BookCategory { BookCategoryId = 51, BookId = "f105484e-5f4b-4a9e-b659-b99cdc4ef2ba", CategoryId = 8 },
                new BookCategory { BookCategoryId = 52, BookId = "afe2affa-c3a6-42d6-97ae-ae2bb32f6252", CategoryId = 9 },
                new BookCategory { BookCategoryId = 53, BookId = "afe2affa-c3a6-42d6-97ae-ae2bb32f6252", CategoryId = 25 },
                new BookCategory { BookCategoryId = 54, BookId = "afe2affa-c3a6-42d6-97ae-ae2bb32f6252", CategoryId = 26 },
                new BookCategory { BookCategoryId = 55, BookId = "ba599047-7bf3-43b5-b878-0443392a092d", CategoryId = 10 },
                new BookCategory { BookCategoryId = 56, BookId = "cb1c497b-2822-4154-a876-23678c6406f2", CategoryId = 17 },
                new BookCategory { BookCategoryId = 57, BookId = "cb1c497b-2822-4154-a876-23678c6406f2", CategoryId = 5 }
            );
        }
    }
}
