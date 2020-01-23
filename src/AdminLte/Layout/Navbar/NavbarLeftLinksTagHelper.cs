using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Text;
using System.Threading.Tasks;

namespace AdminLte.Layout.MainSidebar
{
    [HtmlTargetElement("lte-navbar-left-links", ParentTag = "lte-navbar")]
    public class NavbarLeftLinksTagHelper : LteTagHelperBase
    {
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "ul";
            output.Attributes.Add("class", "navbar-nav");
            output.Content.SetHtmlContent(await BuildHtmlContentAsync(output));
        }

        private string BuildMainSidebarTogglerHtml()
        {
            var sb = new StringBuilder();

            sb.Append(@"<li class=""nav-item"">");
            sb.Append(@"<a class=""nav-link"" data-widget=""pushmenu"" href=""#""><i class=""fas fa-bars""></i></a>");
            sb.Append("</li>");

            return sb.ToString();
        }

        private async Task<string> BuildHtmlContentAsync(TagHelperOutput output)
        {
            var sb = new StringBuilder();

            sb.Append(BuildMainSidebarTogglerHtml());
            sb.Append((await output.GetChildContentAsync()).GetContent());

            return sb.ToString();
        }
    }
}
