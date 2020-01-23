using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Threading.Tasks;

namespace AdminLte.Layout.Navbar
{
    [HtmlTargetElement("lte-navbar", ParentTag = "lte-wrapper")]
    public class NavbarTagHelper : LteTagHelperBase
    {
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "nav";
            output.Attributes.Add("class", "main-header navbar navbar-expand navbar-white navbar-light");
            output.Content.SetHtmlContent((await output.GetChildContentAsync()).GetContent());
        }
    }
}
