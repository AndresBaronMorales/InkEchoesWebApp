using InkEchoes.DataAccess.Data;
using InkEchoes.DataAccess.Repository.IRepository;

namespace InkEchoes.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;
        public ILanguageRepository LanguageRepository { get; private set; }
        public ICategoryRepository CategoryRepository { get; private set; }
        public IGenreRepository GenreRepository { get; private set; }


        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            LanguageRepository = new LanguageRepository(_db);
            CategoryRepository = new CategoryRepository(_db);
            GenreRepository = new GenreRepository(_db);
        }


        public async Task SaveAsync() => await _db.SaveChangesAsync();

    }
}
