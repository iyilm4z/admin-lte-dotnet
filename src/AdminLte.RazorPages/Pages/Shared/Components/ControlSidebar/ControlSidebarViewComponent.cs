using Microsoft.AspNetCore.Mvc;

namespace AdminLte.RazorPages.Pages.Shared.Components.ControlSidebar
{
    public class ControlSidebarViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke() => View();
    }
}