using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Threading.Tasks;

namespace AdminLte.Layout.Footer
{
    [HtmlTargetElement("lte-footer-left", ParentTag = "lte-footer")]
    public class FooterLeftTagHelper : LteTagHelperBase
    {
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "";
            output.Content.SetHtmlContent((await output.GetChildContentAsync()).GetContent());
        }
    }
}
