using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Threading.Tasks;

namespace AdminLte.Core.Layout
{
    [HtmlTargetElement("lte-wrapper")]
    public class WrapperTagHelper : LteTagHelperBase
    {
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            var childContent = (await output.GetChildContentAsync()).GetContent();

            output.TagName = "div";
            output.Attributes.Add("class", "wrapper");

            output.Content.SetHtmlContent(childContent);
        }
    }
}
