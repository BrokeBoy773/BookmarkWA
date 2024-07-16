namespace Bookmark.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Articles()
        {
            return View();
        }
    }
}
