using Microsoft.AspNetCore.Html;

namespace AdminLte.Core.Layout.Footer
{
    public class FooterTagHelperContext
    {
        public IHtmlContent RightHtmlContent { get; set; }
        public IHtmlContent LeftHtmlContent { get; set; }
    }
}
