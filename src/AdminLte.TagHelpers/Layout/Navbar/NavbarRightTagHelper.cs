using AdminLte.TagHelpers.Layout.Navbar;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Threading.Tasks;

namespace AdminLte.TagHelpers.Layout.MainSidebar
{
    [HtmlTargetElement("lte-navbar-right", ParentTag = "lte-navbar")]
    public class NavbarRightTagHelper : LteTagHelperBase
    {
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "";

            var modalContext = (NavBarTagHelperContext)context.Items[typeof(NavBarTagHelperContext)];
            modalContext.NavbarRightHtml = (await output.GetChildContentAsync()).GetContent();

            output.SuppressOutput();
        }
    }
}
