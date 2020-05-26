using Microsoft.AspNetCore.Mvc;

namespace AdminLte.TagHelpers.Demo.Pages.Shared.Components.Footer
{
    public class FooterViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke() => View();
    }
}