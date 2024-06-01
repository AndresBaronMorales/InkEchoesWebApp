using InkEchoes.DataAccess.Data;
using InkEchoes.DataAccess.Repository.IRepository;
using InkEchoes.Models;

namespace InkEchoes.DataAccess.Repository
{
    public class LanguageRepository : Repository<Language>, ILanguageRepository
    {
        private readonly ApplicationDbContext _db;


        public LanguageRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }


        public void Update(Language language) => _db.Languages.Update(language);
    }
}
