using InkEchoes.Models;
using InkEchoes.Models.ViewModels;

namespace InkEchoes.Services.IServices
{
    public interface IBooksPublicService
    {
        Task<IEnumerable<BookTopVM>> GetTopAsync();
        Task<IEnumerable<BookBestSellersVM>> GetBestSellersAsync();
        Task<IEnumerable<Book>> GetAllAsync();
    }
}
