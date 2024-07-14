using InkEchoes.DataAccess.Data;
using InkEchoes.DataAccess.Repository.IRepository;
using InkEchoes.Models;

namespace InkEchoes.DataAccess.Repository
{
    public class BooksGenresRepository : Repository<BookGenre>, IBooksGenresRepository
    {
        private readonly ApplicationDbContext _db;

        public BooksGenresRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(BookGenre bookGenre)
        {
            throw new NotImplementedException();
        }
    }
}
