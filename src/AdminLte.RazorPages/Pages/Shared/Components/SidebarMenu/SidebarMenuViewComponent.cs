using Microsoft.AspNetCore.Mvc;

namespace AdminLte.RazorPages.Pages.Shared.Components.SidebarMenu
{
    public class SidebarMenuViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke() => View();
    }
}