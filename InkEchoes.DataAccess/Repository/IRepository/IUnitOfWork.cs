namespace InkEchoes.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork
    {
        ILanguageRepository LanguageRepository { get; }
        ICategoryRepository CategoryRepository { get; }
        IGenreRepository GenreRepository { get; }
        IAuthorRepository AuthorRepository { get; }
        IBookRepository BookRepository { get; }
        IBookImagesRepository BookImagesRepository { get; }
        IBooksGenresRepository BooksGenresRepository { get; }
        IBooksCategoriesRepository BooksCategoriesRepository { get; }
        IBooksLanguagesRepository BooksLanguagesRepository { get; }

        Task SaveAsync();
    }
}
