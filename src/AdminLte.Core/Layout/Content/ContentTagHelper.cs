using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Text;
using System.Threading.Tasks;

namespace AdminLte.Core.Layout.Content
{
    [HtmlTargetElement("lte-content")]
    public class ContentTagHelper : LteTagHelperBase
    {
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            var contentContext = new ContentTagHelperContext();
            context.Items.Add(typeof(ContentTagHelperContext), contentContext);

            await output.GetChildContentAsync();

            output.TagName = "div";
            output.Attributes.Add("class", "content-wrapper");

            var content = await BuildHtmlContentAsync(contentContext, output);
            output.Content.SetHtmlContent(content);
        }

        public async Task<string> BuildHtmlContentAsync(ContentTagHelperContext contentContext, TagHelperOutput output)
        {
            if (contentContext.HeaderHtmlContent == null
                && contentContext.BodyHtmlContent == null)
                return (await output.GetChildContentAsync()).GetContent();

            var sb = new StringBuilder();

            if (contentContext.HeaderHtmlContent != null)
            {
                sb.Append(ConvertToHtmlString(contentContext.HeaderHtmlContent));
            }

            if (contentContext.BodyHtmlContent != null)
            {
                sb.Append(ConvertToHtmlString(contentContext.BodyHtmlContent));
            }

            return sb.ToString();
        }
    }
}
