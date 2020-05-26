using Microsoft.AspNetCore.Mvc;

namespace AdminLte.Mvc.Views.Shared.Components.FooterLeft
{
    public class FooterLeftViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke() => View();
    }
}