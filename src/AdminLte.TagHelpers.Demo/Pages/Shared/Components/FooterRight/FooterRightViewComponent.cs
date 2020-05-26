using Microsoft.AspNetCore.Mvc;

namespace AdminLte.TagHelpers.Demo.Pages.Shared.Components.FooterRight
{
    public class FooterRightViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke() => View();
    }
}