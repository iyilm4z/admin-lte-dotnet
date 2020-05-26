using Microsoft.AspNetCore.Mvc;

namespace AdminLte.RazorPages.Pages.Shared.Components.SidebarUserPanel
{
    public class SidebarUserPanelViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke() => View();
    }
}