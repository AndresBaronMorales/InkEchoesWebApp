using Microsoft.AspNetCore.Mvc;

namespace InkEchoes.Areas.InkEchoes.Controllers
{
    public class BooksController : Controller
    {
        public IActionResult Books()
        {
            return View();
        }
    }
}
