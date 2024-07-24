using InkEchoes.DataAccess.Data;
using InkEchoes.DataAccess.Repository.IRepository;

namespace InkEchoes.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;


        public ICategoryRepository CategoryRepository { get; private set; }
        public IAuthorRepository AuthorRepository { get; private set; }
        public IBookRepository BookRepository { get; private set; }
        public IBookImagesRepository BookImagesRepository { get; private set; }
        public IBooksCategoriesRepository BooksCategoriesRepository { get; private set; }


        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            CategoryRepository = new CategoryRepository(_db);
            AuthorRepository = new AuthorRepository(_db);
            BookRepository = new BookRepository(_db);
            BookImagesRepository = new BookImagesRepository(_db);
            BooksCategoriesRepository = new BooksCategoriesRepository(_db);
        }


        public async Task SaveAsync() => await _db.SaveChangesAsync();
    }
}
