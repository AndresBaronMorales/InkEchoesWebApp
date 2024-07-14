using InkEchoes.Services.IServices;
using Microsoft.AspNetCore.Mvc;

namespace InkEchoes.Areas.InkEchoes.Controllers
{
    public class Home : Controller
    {
        private IBooksPublicService _booksPublicService;


        public Home(IBooksPublicService booksPublicService)
        {
            _booksPublicService = booksPublicService;
        }


        public IActionResult Index()
        {




            return View();
        }
    }
}
