using AdminLte.TagHelpers.Layout.Navbar;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Threading.Tasks;

namespace AdminLte.TagHelpers.Layout.MainSidebar
{
    [HtmlTargetElement("lte-navbar-left", ParentTag = "lte-navbar")]
    public class NavbarLeftTagHelper : LteTagHelperBase
    {
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "";

            var modalContext = (NavBarTagHelperContext)context.Items[typeof(NavBarTagHelperContext)];
            modalContext.NavbarLeftHtml = (await output.GetChildContentAsync()).GetContent();

            output.SuppressOutput();
        }
    }
}
