using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Threading.Tasks;

namespace AdminLte.Layout.ControlSidebar
{
    [HtmlTargetElement("lte-control-sidebar", ParentTag = "lte-wrapper")]
    public class ControlSidebarTagHelper : LteTagHelperBase
    {
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "aside";
            output.Attributes.Add("class", "control-sidebar control-sidebar-dark");
            output.Content.SetHtmlContent((await output.GetChildContentAsync()).GetContent());
        }
    }
}
