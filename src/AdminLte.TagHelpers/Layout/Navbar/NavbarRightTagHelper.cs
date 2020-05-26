using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace AdminLte.TagHelpers.Layout.Navbar
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
