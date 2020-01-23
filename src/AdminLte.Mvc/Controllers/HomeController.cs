using Microsoft.AspNetCore.Mvc;

namespace AdminLte.Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly LteLayoutOptions _options;

        public HomeController(LteLayoutOptions options)
        {
            _options = options;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
