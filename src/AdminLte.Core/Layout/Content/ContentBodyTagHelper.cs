using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Text;
using System.Threading.Tasks;

namespace AdminLte.Core.Layout.Content
{
    [HtmlTargetElement("lte-content-body", ParentTag = "lte-content")]
    [OutputElementHint("div")]
    public class ContentBodyTagHelper : LteTagHelperBase
    {
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            var contentContext = (ContentTagHelperContext)context.Items[typeof(ContentTagHelperContext)];
            contentContext.BodyHtmlContent = await BuildHtmlContentAsync(output);

            output.SuppressOutput();
        }

        public async Task<HtmlString> BuildHtmlContentAsync(TagHelperOutput output)
        {
            var sb = new StringBuilder();

            sb.Append(@"<div class=""content"">");
            sb.Append((await output.GetChildContentAsync()).GetContent());
            sb.Append("</div>");

            return new HtmlString(sb.ToString());
        }
    }
}
