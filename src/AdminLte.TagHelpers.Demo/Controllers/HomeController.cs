using Microsoft.AspNetCore.Mvc;

namespace AdminLte.TagHelpers.Demo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();
    }
}
