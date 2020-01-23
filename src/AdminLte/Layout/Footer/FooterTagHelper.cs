using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Threading.Tasks;

namespace AdminLte.Layout.Footer
{
    [HtmlTargetElement("lte-footer", ParentTag = "lte-wrapper")]
    public class FooterTagHelper : LteTagHelperBase
    {
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "footer";
            output.Attributes.Add("class", "main-footer");
            output.Content.SetHtmlContent((await output.GetChildContentAsync()).GetContent());
        }
    }
}
