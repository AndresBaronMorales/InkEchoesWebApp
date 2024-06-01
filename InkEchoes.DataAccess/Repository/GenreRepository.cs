using InkEchoes.DataAccess.Data;
using InkEchoes.DataAccess.Repository.IRepository;
using InkEchoes.Models;

namespace InkEchoes.DataAccess.Repository
{
    public class GenreRepository : Repository<Genre>, IGenreRepository
    {
        private readonly ApplicationDbContext _db;


        public GenreRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }


        public void Update(Genre genre) => _db.Genres.Update(genre);

    }
}
