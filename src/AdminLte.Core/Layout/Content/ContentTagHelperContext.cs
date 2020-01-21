using Microsoft.AspNetCore.Html;

namespace AdminLte.Core.Layout.Content
{
    public class ContentTagHelperContext
    {
        public IHtmlContent HeaderHtmlContent { get; set; }
        public IHtmlContent BodyHtmlContent { get; set; }
    }
}
