using InkEchoes.DataAccess.Data;
using InkEchoes.DataAccess.Repository.IRepository;
using InkEchoes.Models;

namespace InkEchoes.DataAccess.Repository
{
    public class BooksCategoriesRepository : Repository<BookCategory>, IBooksCategoriesRepository
    {
        private readonly ApplicationDbContext _db;

        public BooksCategoriesRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(BookCategory bookCategory)
        {
            throw new NotImplementedException();
        }
    }
}
