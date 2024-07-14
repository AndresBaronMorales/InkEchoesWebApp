using InkEchoes.Models;

namespace InkEchoes.DataAccess.Repository.IRepository
{
    public interface IBooksLanguagesRepository : IRepository<BookLanguage>
    {
        void Update(BookLanguage bookLanguage);
    }
}
