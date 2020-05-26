using Microsoft.AspNetCore.Mvc;

namespace AdminLte.Mvc.Views.Shared.Components.HeaderMessagesMenu
{
    public class HeaderMessagesMenuViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke() => View();
    }
}