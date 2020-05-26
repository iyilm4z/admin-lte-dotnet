using Microsoft.AspNetCore.Mvc;

namespace AdminLte.RazorPages.Pages.Shared.Components.HeaderLeft
{
    public class HeaderLeftViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke() => View();
    }
}