using InkEchoes.Models;

namespace InkEchoes.DataAccess.Repository.IRepository
{
    public interface IBooksCategoriesRepository : IRepository<BookCategory>
    {
        void Update(BookCategory bookCategory);
    }
}
