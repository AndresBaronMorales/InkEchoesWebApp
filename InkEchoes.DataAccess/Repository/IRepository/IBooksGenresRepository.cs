using InkEchoes.Models;

namespace InkEchoes.DataAccess.Repository.IRepository
{
    public interface IBooksGenresRepository : IRepository<BookGenre>
    {
        void Update(BookGenre bookGenre);
    }
}
