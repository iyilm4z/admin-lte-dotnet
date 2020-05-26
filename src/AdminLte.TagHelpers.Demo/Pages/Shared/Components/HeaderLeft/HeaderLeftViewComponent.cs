using Microsoft.AspNetCore.Mvc;

namespace AdminLte.TagHelpers.Demo.Pages.Shared.Components.HeaderLeft
{
    public class HeaderLeftViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke() => View();
    }
}