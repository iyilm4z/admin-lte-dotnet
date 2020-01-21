using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Text;
using System.Threading.Tasks;

namespace AdminLte.Core.Layout.Footer
{
    [HtmlTargetElement("lte-footer", ParentTag = "lte-wrapper")]
    [OutputElementHint("footer")]
    public class FooterTagHelper : LteTagHelperBase
    {
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            var footerContext = new FooterTagHelperContext();
            context.Items.Add(typeof(FooterTagHelperContext), footerContext);

            await output.GetChildContentAsync();

            output.TagName = "footer";
            output.Attributes.Add("class", "main-footer");

            var content = await BuildHtmlContentAsync(footerContext, output);
            output.Content.SetHtmlContent(content);
        }

        public async Task<string> BuildHtmlContentAsync(FooterTagHelperContext footerContext, TagHelperOutput output)
        {
            if (footerContext.RightHtmlContent == null
                && footerContext.LeftHtmlContent == null)
                return (await output.GetChildContentAsync()).GetContent();

            var sb = new StringBuilder();

            if (footerContext.RightHtmlContent != null)
            {
                sb.Append(ConvertToHtmlString(footerContext.RightHtmlContent));
            }

            if (footerContext.LeftHtmlContent != null)
            {
                sb.Append(ConvertToHtmlString(footerContext.LeftHtmlContent));
            }

            return sb.ToString();
        }
    }
}
