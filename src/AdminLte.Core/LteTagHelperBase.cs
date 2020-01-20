using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.IO;
using System.Text.Encodings.Web;

namespace AdminLte.Core
{
    public abstract class LteTagHelperBase : TagHelper
    {
        public static string ConvertToHtmlString(IHtmlContent htmlContent)
        {
            if (htmlContent == null)
                return "";

            if (htmlContent is HtmlString htmlString)
                return htmlString.Value;

            using var writer = new StringWriter();
            htmlContent.WriteTo(writer, HtmlEncoder.Default);
            return writer.ToString();
        }
    }
}
