using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Text;
using System.Threading.Tasks;

namespace AdminLte.Core.Layout.Footer
{
    [HtmlTargetElement("lte-footer-right", ParentTag = "lte-footer")]
    [OutputElementHint("div")]
    public class FooterRightTagHelper : LteTagHelperBase
    {
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            var footerContext = (FooterTagHelperContext)context.Items[typeof(FooterTagHelperContext)];
            footerContext.RightHtmlContent = await BuildHtmlContentAsync(output);

            output.SuppressOutput();
        }

        public async Task<HtmlString> BuildHtmlContentAsync(TagHelperOutput output)
        {
            var sb = new StringBuilder();

            sb.Append(@"<div class=""float-right d-none d-sm-block"">");
            sb.Append((await output.GetChildContentAsync()).GetContent());
            sb.Append("</div>");

            return new HtmlString(sb.ToString());
        }
    }
}
