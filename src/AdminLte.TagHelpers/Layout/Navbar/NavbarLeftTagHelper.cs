using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace AdminLte.TagHelpers.Layout.Navbar
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
