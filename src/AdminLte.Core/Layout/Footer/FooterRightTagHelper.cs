using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Threading.Tasks;

namespace AdminLte.Core.Layout.Footer
{
    [HtmlTargetElement("lte-footer-right")]
    public class FooterRightTagHelper : LteTagHelperBase
    {
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            var childContent = await output.GetChildContentAsync();
            var modalContext = (FooterTagHelperContext)context.Items[typeof(FooterTagHelperContext)];
            modalContext.RightHtmlContent = childContent;
            output.SuppressOutput();
        }
    }
}
