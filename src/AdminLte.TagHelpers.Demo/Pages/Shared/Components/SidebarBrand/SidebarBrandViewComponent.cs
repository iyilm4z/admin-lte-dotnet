using Microsoft.AspNetCore.Mvc;

namespace AdminLte.TagHelpers.Demo.Pages.Shared.Components.SidebarBrand
{
    public class SidebarBrandViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke() => View();
    }
}