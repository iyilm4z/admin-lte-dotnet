using Microsoft.AspNetCore.Mvc;

namespace AdminLte.TagHelpers.Demo.Pages.Shared.Components.SidebarUserPanel
{
    public class SidebarUserPanelViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke() => View();
    }
}