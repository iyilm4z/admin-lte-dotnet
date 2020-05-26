using Microsoft.AspNetCore.Mvc;

namespace AdminLte.TagHelpers.Demo.Pages.Shared.Components.ControlSidebar
{
    public class ControlSidebarViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke() => View();
    }
}