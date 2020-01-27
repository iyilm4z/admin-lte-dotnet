using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Text;
using System.Threading.Tasks;

namespace AdminLte.TagHelpers.Layout.Content
{
    [HtmlTargetElement("lte-content-header", ParentTag = "lte-content")]
    public class ContentHeaderTagHelper : LteTagHelperBase
    {
        private const string IsFluidAttributeName = "fluid";
        private const string TitleAttributeName = "title";
        private const string EnableBreadcrumbAttributeName = "breadcrumb";

        [HtmlAttributeName(IsFluidAttributeName)]
        public bool IsFluid { get; set; } = true;

        [HtmlAttributeName(TitleAttributeName)]
        public string Title { get; set; }

        [HtmlAttributeName(EnableBreadcrumbAttributeName)]
        public bool EnableBreadcrumb { get; set; }

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "section";
            output.Attributes.Add("class", "content-header");
            output.PreContent.SetHtmlContent(string.Format(@"<div class=""{0}"">", IsFluid ? "container-fluid" : "container"));
            output.Content.SetHtmlContent(await BuildHtmlContentAsync(output));
            output.PostContent.SetHtmlContent("</div>");
        }

        private async Task<string> BuildHtmlContentAsync(TagHelperOutput output)
        {
            var sb = new StringBuilder();

            sb.Append(@"<div class=""row mb-2"">");

            if (string.IsNullOrEmpty(Title) && !EnableBreadcrumb)
            {
                sb.Append(@"<div class=""col-sm-12"">");

                sb.Append((await output.GetChildContentAsync()).GetContent());

                sb.Append("</div>");
            }
            else
            {
                await AppendTitleAsync(sb, output);

                AppendBreadcrumb(sb);
            }

            sb.Append("</div>");

            return sb.ToString();
        }

        private async Task AppendTitleAsync(StringBuilder sb, TagHelperOutput output)
        {
            sb.AppendFormat(@"<div class=""{0}"">", EnableBreadcrumb ? "col-sm-6" : "col-sm-12");

            if (!string.IsNullOrEmpty(Title))
            {
                sb.AppendFormat("<h1>{0}</h1>", Title);
            }
            else
            {
                sb.Append((await output.GetChildContentAsync()).GetContent());
            }

            sb.Append("</div>");
        }

        private void AppendBreadcrumb(StringBuilder sb)
        {
            if (EnableBreadcrumb)
            {
                sb.Append(@"<div class=""col-sm-6"">");
                sb.Append("breadcrumb TODO");
                sb.Append("</div>");
            }
        }
    }
}
