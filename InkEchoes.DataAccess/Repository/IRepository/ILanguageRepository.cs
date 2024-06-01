using InkEchoes.Models;

namespace InkEchoes.DataAccess.Repository.IRepository
{
    public interface ILanguageRepository : IRepository<Language>
    {
        void Update(Language language);
    }
}
