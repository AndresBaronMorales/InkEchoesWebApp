namespace InkEchoes.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork
    {
        ICategoryRepository CategoryRepository { get; }
        IAuthorRepository AuthorRepository { get; }
        IBookRepository BookRepository { get; }
        IBookImagesRepository BookImagesRepository { get; }
        IBooksCategoriesRepository BooksCategoriesRepository { get; }

        Task SaveAsync();
    }
}
