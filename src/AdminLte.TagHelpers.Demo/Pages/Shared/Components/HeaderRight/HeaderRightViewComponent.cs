using Microsoft.AspNetCore.Mvc;

namespace AdminLte.TagHelpers.Demo.Pages.Shared.Components.HeaderRight
{
    public class HeaderRightViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke() => View();
    }
}