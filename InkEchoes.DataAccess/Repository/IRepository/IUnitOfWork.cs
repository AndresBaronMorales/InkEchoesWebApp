namespace InkEchoes.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork
    {
        ILanguageRepository LanguageRepository { get; }
        ICategoryRepository CategoryRepository { get; }
        IGenreRepository GenreRepository { get; }

        Task SaveAsync();
    }
}
