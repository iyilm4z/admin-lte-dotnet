using Microsoft.AspNetCore.Mvc;

namespace AdminLte.RazorPages.Pages.Shared.Components.FooterLeft
{
    public class FooterLeftViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke() => View();
    }
}