using InkEchoes.DataAccess.Data;
using InkEchoes.DataAccess.Repository.IRepository;
using InkEchoes.Models;

namespace InkEchoes.DataAccess.Repository
{
    public class BooksLanguagesRepository : Repository<BookLanguage>, IBooksLanguagesRepository
    {
        private readonly ApplicationDbContext _db;

        public BooksLanguagesRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(BookLanguage bookLanguage)
        {
            throw new NotImplementedException();
        }
    }
}
