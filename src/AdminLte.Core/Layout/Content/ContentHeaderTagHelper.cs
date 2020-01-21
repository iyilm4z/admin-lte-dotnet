using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Text;
using System.Threading.Tasks;

namespace AdminLte.Core.Layout.Content
{
    [HtmlTargetElement("lte-content-header")]
    public class ContentHeaderTagHelper : LteTagHelperBase
    {
        [HtmlAttributeName("title")]
        public string Title { get; set; }

        [HtmlAttributeName("fluid")]
        public bool IsFluid { get; set; }

        [HtmlAttributeName("breadcrumb")]
        public bool EnableBreadcrumb { get; set; }

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            var contentContext = (ContentTagHelperContext)context.Items[typeof(ContentTagHelperContext)];
            contentContext.HeaderHtmlContent = await BuildHtmlContentAsync(output);

            output.SuppressOutput();
        }

        private async Task<HtmlString> BuildHtmlContentAsync(TagHelperOutput output)
        {
            var sb = new StringBuilder();

            sb.Append(@"<section class=""content-header"">");
            sb.AppendFormat(@"<div class=""{0}"">", IsFluid ? "container-fluid" : "container");

            await AppendContainer(sb, output);

            sb.Append("</div>");
            sb.Append("</section>");

            return new HtmlString(sb.ToString());
        }

        private async Task AppendContainer(StringBuilder sb, TagHelperOutput output)
        {
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
