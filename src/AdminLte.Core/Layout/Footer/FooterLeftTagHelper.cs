using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Threading.Tasks;

namespace AdminLte.Core.Layout.Footer
{
    [HtmlTargetElement("lte-footer-left")]
    public class FooterLeftTagHelper : LteTagHelperBase
    {
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            var footerContext = (FooterTagHelperContext)context.Items[typeof(FooterTagHelperContext)];
            footerContext.LeftHtmlContent = await output.GetChildContentAsync();
            
            output.SuppressOutput();
        }
    }
}
