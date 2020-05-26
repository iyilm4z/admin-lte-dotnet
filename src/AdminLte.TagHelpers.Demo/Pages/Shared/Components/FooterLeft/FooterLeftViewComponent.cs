using Microsoft.AspNetCore.Mvc;

namespace AdminLte.TagHelpers.Demo.Pages.Shared.Components.FooterLeft
{
    public class FooterLeftViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke() => View();
    }
}