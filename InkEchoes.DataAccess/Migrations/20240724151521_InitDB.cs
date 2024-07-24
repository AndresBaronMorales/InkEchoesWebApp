using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InkEchoes.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class InitDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    AuthorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Nacionality = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.AuthorId);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    BookId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ISBN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    NumberPages = table.Column<int>(type: "int", nullable: false),
                    Origin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Editorial = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(10,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.BookId);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "BookImages",
                columns: table => new
                {
                    BookImageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookImages", x => x.BookImageId);
                    table.ForeignKey(
                        name: "FK_BookImages_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BooksAuthors",
                columns: table => new
                {
                    BooksAuthorsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AuthorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BooksAuthors", x => x.BooksAuthorsId);
                    table.ForeignKey(
                        name: "FK_BooksAuthors_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "AuthorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BooksAuthors_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BooksCategories",
                columns: table => new
                {
                    BookCategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BooksCategories", x => x.BookCategoryId);
                    table.ForeignKey(
                        name: "FK_BooksCategories_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BooksCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorId", "Nacionality", "Name" },
                values: new object[,]
                {
                    { 1, "England", "J. K. Rowling" },
                    { 2, "British India", "George Orwell" },
                    { 3, "South Africa", "J. R. R. Tolkien" },
                    { 4, "U.S.A", "Harper Lee" },
                    { 5, "U.S.A", "F. Scott Fitzgerald" },
                    { 6, "England", "Jane Austen" },
                    { 7, "Australia", "Markus Zusak" },
                    { 8, "U.S.A", "Ernest Hemingway" },
                    { 9, "Colombia", "Gabriel García Márquez" },
                    { 10, "Nigeria", "Chimamanda Ngozi Adichie" },
                    { 11, "England", "Terry Pratchett" },
                    { 12, "England", "Neil Gaiman" },
                    { 13, "Sweden", "Stieg Larsson" },
                    { 14, "U.S.A", "Frank Herbert" },
                    { 15, "U.S.A", "Dan Brown" },
                    { 16, "Israel", "Yuval Noah Harari" },
                    { 17, "U.S.A", "Walter Isaacson" },
                    { 18, "U.S.A", "Stephen King" },
                    { 19, "U.S.A", "Charles Duhigg" },
                    { 20, "U.S.A", "Gillian Flynn" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Description", "Editorial", "ISBN", "NumberPages", "Origin", "Price", "Title" },
                values: new object[,]
                {
                    { "009f9fff-a198-4f37-9824-cf3ad243bb3b", "A romantic novel that also critiques the British landed gentry.", "CreateSpace Independent Publishing Platform", "978-1503290563", 278, "United Kingdom", 79m, "Pride and Prejudice" },
                    { "03a9b093-fcbd-4c71-8d4c-8e68307884b8", "A complex tale of politics, religion, and ecology on the desert planet Arrakis.", "Ace", "978-0441013593", 896, "United States", 179m, "Dune" },
                    { "0e89473b-ab23-43d8-b887-0936f1108413", "A journalist and a hacker team up to solve a decades-old disappearance.", "Vintage Crime/Black Lizard", "978-0307454546", 465, "Sweden", 159m, "The Girl with the Dragon Tattoo" },
                    { "3369e2b3-4149-481d-ac47-1873bf4ee25c", "A novel about the American dream and the Roaring Twenties.", "Scribner", "978-0743273565", 180, "United States", 109m, "The Great Gatsby" },
                    { "4325482a-137b-42e6-9216-3c2c3ab4cd09", "A novel about the Nigerian Civil War through the perspectives of three characters.", "Anchor", "978-1400095209", 560, "Nigeria", 169m, "Half of a Yellow Sun" },
                    { "44c65b5c-1010-4ad0-8483-f19b70007c55", "A novel about the serious issues of rape and racial inequality.", "Harper Perennial Modern Classics", "978-0060935467", 336, "United States", 149m, "To Kill a Mockingbird" },
                    { "58a645a5-e55a-40c9-b2e0-b1144f140840", "A symbologist uncovers a secret society while investigating a murder at the Louvre.", "Anchor", "978-0307474278", 689, "United States", 149m, "The Da Vinci Code" },
                    { "953fc395-3d0c-449b-88bd-ad7f8b52a9d6", "The adventure of Bilbo Baggins as he goes on a quest to reclaim a treasure.", "Del Rey", "978-0345339683", 320, "United Kingdom", 89m, "The Hobbit" },
                    { "a1a80417-3c02-44e4-abb2-d4f04b646c39", "The multi-generational story of the Buendía family in the town of Macondo.", "Harper Perennial Modern Classics", "978-0060883287", 417, "Colombia", 189m, "One Hundred Years of Solitude" },
                    { "ae4225b7-b2a9-4c64-982c-e8034c09a87c", "A story narrated by Death, about a young girl's life in Nazi Germany.", "Knopf Books for Young Readers", "978-0375842207", 552, "Australia", 129m, "The Book Thief" },
                    { "afe2affa-c3a6-42d6-97ae-ae2bb32f6252", "A family becomes isolated in a haunted hotel during the winter.", "Anchor", "978-0307743657", 688, "United States", 149m, "The Shining" },
                    { "ba599047-7bf3-43b5-b878-0443392a092d", "An exploration of the science behind why habits exist and how they can be changed.", "Random House", "978-0812981605", 371, "United States", 169m, "The Power of Habit: Why We Do What We Do in Life and Business" },
                    { "bcb5111b-df8f-473a-a068-ca073df31a9e", "The story of an angel and a demon who team up to prevent the apocalypse.", "HarperTorch", "978-0060853983", 432, "United Kingdom", 14m, "Good Omens: The Nice and Accurate Prophecies of Agnes Nutter, Witch" },
                    { "cb1c497b-2822-4154-a876-23678c6406f2", "A thriller about a man suspected of causing his wife's disappearance.", "Crown Publishing Group", "978-0307588371", 432, "United States", 15m, "Gone Girl" },
                    { "e7021c6d-e793-42d3-b912-0d39faa7c111", "A young boy discovers he is a wizard on his 11th birthday.", "Scholastic", "978-0439708180", 320, "United Kingdom", 19m, "Harry Potter and the Sorcerer's Stone" },
                    { "eb0cf1f2-7d8c-4f23-b69c-381363e608fc", "The story of an aging fisherman and his struggle with a giant marlin.", "Scribner", "978-0684830490", 128, "United States", 89m, "The Old Man and the Sea" },
                    { "f105484e-5f4b-4a9e-b659-b99cdc4ef2ba", "The biography of Steve Jobs, detailing his life and career as a tech visionary.", "Simon & Schuster", "978-1451648539", 656, "United States", 179m, "Steve Jobs" },
                    { "f40f905f-5b5b-412f-a191-0fee276f44a8", "A dystopian novel set in a totalitarian society under constant surveillance.", "Signet Classic", "978-0451524935", 328, "United Kingdom", 99m, "1984" },
                    { "f94aec15-cd4b-448f-9c57-01fa09d08ac4", "An exploration of the history and impact of Homo sapiens on the world.", "Harper", "978-0062316097", 498, "Israel", 185m, "Sapiens: A Brief History of Humankind" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Science Fiction" },
                    { 2, "Fantasy" },
                    { 3, "Mystery" },
                    { 4, "Romance" },
                    { 5, "Thriller" },
                    { 6, "Non-Fiction" },
                    { 7, "Adventure" },
                    { 8, "Biography" },
                    { 9, "Horror" },
                    { 10, "Self-Help" },
                    { 11, "Magical Realism" },
                    { 12, "Fiction" },
                    { 13, "Young Adult" },
                    { 14, "Classic" },
                    { 15, "Drama" },
                    { 16, "Comedy" },
                    { 17, "Crime" },
                    { 18, "Historical" },
                    { 20, "Dystopian" },
                    { 21, "Tragedy" },
                    { 22, "Contemporary" },
                    { 23, "Detective Fiction" },
                    { 24, "Conspiracy" },
                    { 25, "Gothic" },
                    { 26, "Psychological" }
                });

            migrationBuilder.InsertData(
                table: "BooksAuthors",
                columns: new[] { "BooksAuthorsId", "AuthorId", "BookId" },
                values: new object[,]
                {
                    { 1, 1, "e7021c6d-e793-42d3-b912-0d39faa7c111" },
                    { 2, 2, "f40f905f-5b5b-412f-a191-0fee276f44a8" },
                    { 3, 3, "953fc395-3d0c-449b-88bd-ad7f8b52a9d6" },
                    { 4, 4, "44c65b5c-1010-4ad0-8483-f19b70007c55" },
                    { 5, 5, "3369e2b3-4149-481d-ac47-1873bf4ee25c" },
                    { 6, 6, "009f9fff-a198-4f37-9824-cf3ad243bb3b" },
                    { 7, 7, "ae4225b7-b2a9-4c64-982c-e8034c09a87c" },
                    { 8, 8, "eb0cf1f2-7d8c-4f23-b69c-381363e608fc" },
                    { 9, 9, "a1a80417-3c02-44e4-abb2-d4f04b646c39" },
                    { 10, 10, "4325482a-137b-42e6-9216-3c2c3ab4cd09" },
                    { 11, 11, "bcb5111b-df8f-473a-a068-ca073df31a9e" },
                    { 12, 12, "bcb5111b-df8f-473a-a068-ca073df31a9e" },
                    { 13, 13, "0e89473b-ab23-43d8-b887-0936f1108413" },
                    { 14, 14, "03a9b093-fcbd-4c71-8d4c-8e68307884b8" },
                    { 15, 15, "58a645a5-e55a-40c9-b2e0-b1144f140840" },
                    { 16, 16, "f94aec15-cd4b-448f-9c57-01fa09d08ac4" },
                    { 17, 17, "f105484e-5f4b-4a9e-b659-b99cdc4ef2ba" },
                    { 18, 18, "afe2affa-c3a6-42d6-97ae-ae2bb32f6252" },
                    { 19, 19, "ba599047-7bf3-43b5-b878-0443392a092d" },
                    { 20, 20, "cb1c497b-2822-4154-a876-23678c6406f2" }
                });

            migrationBuilder.InsertData(
                table: "BooksCategories",
                columns: new[] { "BookCategoryId", "BookId", "CategoryId" },
                values: new object[,]
                {
                    { 1, "e7021c6d-e793-42d3-b912-0d39faa7c111", 2 },
                    { 2, "e7021c6d-e793-42d3-b912-0d39faa7c111", 7 },
                    { 3, "e7021c6d-e793-42d3-b912-0d39faa7c111", 12 },
                    { 4, "e7021c6d-e793-42d3-b912-0d39faa7c111", 13 },
                    { 5, "f40f905f-5b5b-412f-a191-0fee276f44a8", 20 },
                    { 6, "f40f905f-5b5b-412f-a191-0fee276f44a8", 1 },
                    { 7, "f40f905f-5b5b-412f-a191-0fee276f44a8", 12 },
                    { 8, "f40f905f-5b5b-412f-a191-0fee276f44a8", 14 },
                    { 9, "953fc395-3d0c-449b-88bd-ad7f8b52a9d6", 2 },
                    { 10, "953fc395-3d0c-449b-88bd-ad7f8b52a9d6", 7 },
                    { 11, "953fc395-3d0c-449b-88bd-ad7f8b52a9d6", 12 },
                    { 12, "953fc395-3d0c-449b-88bd-ad7f8b52a9d6", 14 },
                    { 13, "44c65b5c-1010-4ad0-8483-f19b70007c55", 15 },
                    { 14, "44c65b5c-1010-4ad0-8483-f19b70007c55", 18 },
                    { 15, "44c65b5c-1010-4ad0-8483-f19b70007c55", 12 },
                    { 16, "44c65b5c-1010-4ad0-8483-f19b70007c55", 14 },
                    { 17, "3369e2b3-4149-481d-ac47-1873bf4ee25c", 15 },
                    { 18, "3369e2b3-4149-481d-ac47-1873bf4ee25c", 21 },
                    { 19, "3369e2b3-4149-481d-ac47-1873bf4ee25c", 12 },
                    { 20, "3369e2b3-4149-481d-ac47-1873bf4ee25c", 14 },
                    { 21, "009f9fff-a198-4f37-9824-cf3ad243bb3b", 4 },
                    { 22, "009f9fff-a198-4f37-9824-cf3ad243bb3b", 15 },
                    { 23, "009f9fff-a198-4f37-9824-cf3ad243bb3b", 12 },
                    { 24, "009f9fff-a198-4f37-9824-cf3ad243bb3b", 14 },
                    { 25, "ae4225b7-b2a9-4c64-982c-e8034c09a87c", 18 },
                    { 26, "ae4225b7-b2a9-4c64-982c-e8034c09a87c", 15 },
                    { 27, "ae4225b7-b2a9-4c64-982c-e8034c09a87c", 12 },
                    { 28, "ae4225b7-b2a9-4c64-982c-e8034c09a87c", 13 },
                    { 29, "eb0cf1f2-7d8c-4f23-b69c-381363e608fc", 7 },
                    { 30, "eb0cf1f2-7d8c-4f23-b69c-381363e608fc", 15 },
                    { 31, "eb0cf1f2-7d8c-4f23-b69c-381363e608fc", 12 },
                    { 32, "eb0cf1f2-7d8c-4f23-b69c-381363e608fc", 14 },
                    { 33, "a1a80417-3c02-44e4-abb2-d4f04b646c39", 11 },
                    { 34, "a1a80417-3c02-44e4-abb2-d4f04b646c39", 18 },
                    { 35, "a1a80417-3c02-44e4-abb2-d4f04b646c39", 12 },
                    { 36, "a1a80417-3c02-44e4-abb2-d4f04b646c39", 14 },
                    { 37, "4325482a-137b-42e6-9216-3c2c3ab4cd09", 18 },
                    { 38, "4325482a-137b-42e6-9216-3c2c3ab4cd09", 15 },
                    { 39, "4325482a-137b-42e6-9216-3c2c3ab4cd09", 12 },
                    { 40, "4325482a-137b-42e6-9216-3c2c3ab4cd09", 22 },
                    { 41, "bcb5111b-df8f-473a-a068-ca073df31a9e", 9 },
                    { 42, "bcb5111b-df8f-473a-a068-ca073df31a9e", 2 },
                    { 43, "bcb5111b-df8f-473a-a068-ca073df31a9e", 16 },
                    { 44, "0e89473b-ab23-43d8-b887-0936f1108413", 5 },
                    { 45, "03a9b093-fcbd-4c71-8d4c-8e68307884b8", 1 },
                    { 46, "58a645a5-e55a-40c9-b2e0-b1144f140840", 3 },
                    { 47, "58a645a5-e55a-40c9-b2e0-b1144f140840", 23 },
                    { 48, "58a645a5-e55a-40c9-b2e0-b1144f140840", 24 },
                    { 49, "58a645a5-e55a-40c9-b2e0-b1144f140840", 5 },
                    { 50, "f94aec15-cd4b-448f-9c57-01fa09d08ac4", 6 },
                    { 51, "f105484e-5f4b-4a9e-b659-b99cdc4ef2ba", 8 },
                    { 52, "afe2affa-c3a6-42d6-97ae-ae2bb32f6252", 9 },
                    { 53, "afe2affa-c3a6-42d6-97ae-ae2bb32f6252", 25 },
                    { 54, "afe2affa-c3a6-42d6-97ae-ae2bb32f6252", 26 },
                    { 55, "ba599047-7bf3-43b5-b878-0443392a092d", 10 },
                    { 56, "cb1c497b-2822-4154-a876-23678c6406f2", 17 },
                    { 57, "cb1c497b-2822-4154-a876-23678c6406f2", 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Authors_Name",
                table: "Authors",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BookImages_BookId",
                table: "BookImages",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_BooksAuthors_AuthorId",
                table: "BooksAuthors",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_BooksAuthors_BookId",
                table: "BooksAuthors",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_BooksCategories_BookId",
                table: "BooksCategories",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_BooksCategories_CategoryId",
                table: "BooksCategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_CategoryName",
                table: "Categories",
                column: "CategoryName",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookImages");

            migrationBuilder.DropTable(
                name: "BooksAuthors");

            migrationBuilder.DropTable(
                name: "BooksCategories");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
