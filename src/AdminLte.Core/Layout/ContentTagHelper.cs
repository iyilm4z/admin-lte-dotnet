using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Threading.Tasks;

namespace AdminLte.Core.Layout
{
    [HtmlTargetElement("lte-content")]
    public class ContentTagHelper : LteTagHelperBase
    {
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            var childContent = (await output.GetChildContentAsync()).GetContent();

            output.TagName = "div";
            output.Attributes.Add("class", "content-wrapper");

            output.Content.SetHtmlContent(childContent);
        }
    }
}
