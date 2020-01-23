using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Threading.Tasks;

namespace AdminLte.Layout.Content
{
    [HtmlTargetElement("lte-content-body", ParentTag = "lte-content")]
    public class ContentBodyTagHelper : LteTagHelperBase
    {
        private const string IsFluidAttributeName = "fluid";

        [HtmlAttributeName(IsFluidAttributeName)]
        public bool IsFluid { get; set; } = true;

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            output.Attributes.Add("class", "content");
            output.PreContent.SetHtmlContent(string.Format(@"<div class=""{0}"">", IsFluid ? "container-fluid" : "container"));
            output.Content.SetHtmlContent((await output.GetChildContentAsync()).GetContent());
            output.PostContent.SetHtmlContent("</div>");
        }
    }
}
