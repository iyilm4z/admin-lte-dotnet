using Microsoft.AspNetCore.Mvc;

namespace AdminLte.TagHelpers.Demo.Pages.Shared.Components.HeaderMessagesMenu
{
    public class HeaderMessagesMenuViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke() => View();
    }
}