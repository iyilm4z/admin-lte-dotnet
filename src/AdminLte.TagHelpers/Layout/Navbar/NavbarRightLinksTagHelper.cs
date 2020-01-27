using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Text;
using System.Threading.Tasks;

namespace AdminLte.TagHelpers.Layout.MainSidebar
{
    [HtmlTargetElement("lte-navbar-right-links", ParentTag = "lte-navbar")]
    public class NavbarRightLinksTagHelper : LteTagHelperBase
    {
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "ul";
            output.Attributes.Add("class", "navbar-nav ml-auto");
            output.Content.SetHtmlContent(await BuildHtmlContentAsync(output));
        }

        private string BuildControlSidebarTogglerHtml()
        {
            var sb = new StringBuilder();

            sb.Append(@"<li class=""nav-item"">");
            sb.Append(@"<a class=""nav-link"" data-widget=""control-sidebar"" data-slide=""true"" href=""#"">");
            sb.Append(@"<i class=""fas fa-th-large""></i>");
            sb.Append("</a>");
            sb.Append("</li>");

            return sb.ToString();
        }

        private async Task<string> BuildHtmlContentAsync(TagHelperOutput output)
        {
            var sb = new StringBuilder();

            sb.Append((await output.GetChildContentAsync()).GetContent());
            sb.Append(BuildControlSidebarTogglerHtml());

            return sb.ToString();
        }
    }
}
