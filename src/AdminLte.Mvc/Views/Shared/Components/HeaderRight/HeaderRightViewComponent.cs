using Microsoft.AspNetCore.Mvc;

namespace AdminLte.Mvc.Views.Shared.Components.HeaderRight
{
    public class HeaderRightViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke() => View();
    }
}