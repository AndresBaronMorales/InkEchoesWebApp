using InkEchoes.Models;

namespace InkEchoes.DataAccess.Repository.IRepository
{
    public interface IAuthorRepository : IRepository<Author>
    {
        void Update(Author author);
    }
}
