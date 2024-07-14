using InkEchoes.Models;

namespace InkEchoes.DataAccess.Repository.IRepository
{
    public interface IBookImagesRepository : IRepository<BookImage>
    {
        void Update(BookImage bookImage);
    }
}
