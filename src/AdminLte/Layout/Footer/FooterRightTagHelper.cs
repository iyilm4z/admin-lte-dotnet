using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Threading.Tasks;

namespace AdminLte.Layout.Footer
{
    [HtmlTargetElement("lte-footer-right", ParentTag = "lte-footer")]
    public class FooterRightTagHelper : LteTagHelperBase
    {
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            output.Attributes.Add("class", "float-right d-none d-sm-block");
            output.Content.SetHtmlContent((await output.GetChildContentAsync()).GetContent());
        }
    }
}
