using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Threading.Tasks;

namespace AdminLte.Layout.MainSidebar
{
    [HtmlTargetElement("lte-main-sidebar", ParentTag = "lte-wrapper")]
    public class MainSidebarTagHelper : LteTagHelperBase
    {
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "aside";
            output.Attributes.Add("class", "main-sidebar sidebar-dark-primary elevation-4");
            output.Content.SetHtmlContent((await output.GetChildContentAsync()).GetContent());
        }
    }
}
