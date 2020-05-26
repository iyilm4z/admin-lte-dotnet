using Microsoft.AspNetCore.Mvc;

namespace AdminLte.Mvc.Views.Shared.Components.Footer
{
    public class FooterViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke() => View();
    }
}