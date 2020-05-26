using Microsoft.AspNetCore.Mvc;

namespace AdminLte.RazorPages.Pages.Shared.Components.Header
{
    public class HeaderViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke() => View();
    }
}