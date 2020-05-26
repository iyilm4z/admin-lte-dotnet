using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Linq;
using System.Threading.Tasks;

namespace AdminLte.TagHelpers.Layout
{
    [HtmlTargetElement("lte-wrapper")]
    public class WrapperTagHelper : LteTagHelperBase
    {
        private readonly LteLayoutOptions _lteLayoutOptions;

        public WrapperTagHelper(LteLayoutOptions lteLayoutOptions)
        {
            _lteLayoutOptions = lteLayoutOptions;
        }

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            var childContent = (await output.GetChildContentAsync()).GetContent();

            output.TagName = "div";

            var classes = _lteLayoutOptions.WrapperClasses.Distinct()
                .Aggregate("wrapper", (current, wrapperClass) => current + $" {wrapperClass}");

            output.Attributes.Add("class", classes);
            output.Content.SetHtmlContent(childContent);
        }
    }
}
