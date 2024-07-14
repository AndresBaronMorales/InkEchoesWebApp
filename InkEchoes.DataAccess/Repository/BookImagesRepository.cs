using InkEchoes.DataAccess.Data;
using InkEchoes.DataAccess.Repository.IRepository;
using InkEchoes.Models;

namespace InkEchoes.DataAccess.Repository
{
    public class BookImagesRepository : Repository<BookImage>, IBookImagesRepository
    {
        private readonly ApplicationDbContext _db;

        public BookImagesRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(BookImage bookImage)
        {
            throw new NotImplementedException();
        }
    }
}
