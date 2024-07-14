using InkEchoes.Models;

namespace InkEchoes.DataAccess.Repository.IRepository
{
    public interface IBookRepository : IRepository<Book>
    {
        void Update(Book book);
    }
}
