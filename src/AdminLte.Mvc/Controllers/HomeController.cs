using Microsoft.AspNetCore.Mvc;

namespace AdminLte.Mvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();
    }
}