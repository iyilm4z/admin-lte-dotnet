using Microsoft.AspNetCore.Mvc;

namespace AdminLte.Mvc.Views.Shared.Components.HeaderLeft
{
    public class HeaderLeftViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke() => View();
    }
}