using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Text;
using System.Threading.Tasks;

namespace AdminLte.TagHelpers.Layout.Navbar
{
    [HtmlTargetElement("lte-navbar")]
    public class NavbarTagHelper : LteTagHelperBase
    {
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            var navbarContext = new NavBarTagHelperContext();
            context.Items.Add(typeof(NavBarTagHelperContext), navbarContext);

            await output.GetChildContentAsync();

            output.TagName = "nav";
            output.Attributes.Add("class", "main-header navbar navbar-expand navbar-white navbar-light");
            output.Content.SetHtmlContent(BuildHtmlContent(navbarContext));
        }

        private string BuildMainSidebarTogglerHtml()
        {
            var sb = new StringBuilder();
            sb.Append(@"<ul class=""navbar-nav"">");
            sb.Append(@"<li class=""nav-item"">");
            sb.Append(@"<a class=""nav-link"" data-widget=""pushmenu"" href=""#"">");
            sb.Append(@"<i class=""fas fa-bars""></i>");
            sb.Append("</a>");
            sb.Append("</li>");
            sb.Append(@"</ul>");

            return sb.ToString();
        }

        private string BuildControlSidebarTogglerHtml()
        {
            var sb = new StringBuilder();

            sb.Append(@"<ul class=""navbar-nav"">");
            sb.Append(@"<li class=""nav-item"">");
            sb.Append(@"<a class=""nav-link"" data-widget=""control-sidebar"" data-slide=""true"" href=""#"">");
            sb.Append(@"<i class=""fas fa-th-large""></i>");
            sb.Append("</a>");
            sb.Append("</li>");
            sb.Append(@"</ul>");

            return sb.ToString();
        }

        private string BuildHtmlContent(NavBarTagHelperContext navbarContext)
        {
            var sb = new StringBuilder();

            BuildNavbarLeftContent(navbarContext, sb);
            BuildNavbarRightContent(navbarContext, sb);

            return sb.ToString();
        }

        private void BuildNavbarLeftContent(NavBarTagHelperContext navbarContext, StringBuilder sb)
        {
            sb.Append(BuildMainSidebarTogglerHtml());
            sb.Append(navbarContext.NavbarLeftHtml);
        }

        private void BuildNavbarRightContent(NavBarTagHelperContext navbarContext, StringBuilder sb)
        {
            // this empty ul fixes
            sb.Append(@"<ul class=""navbar-nav ml-auto"">");
            sb.Append(@"<li class=""nav-item"">&nbsp;</li>");
            sb.Append(@"</ul>");
            sb.Append(navbarContext.NavbarRightHtml);
            sb.Append(BuildControlSidebarTogglerHtml());
        }
    }
}
