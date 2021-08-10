using System.Web;
using System.Web.Mvc;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;

namespace CleanBlog.Core.Extensions
{
    public static class HtmlExtensions
    {
        public static IHtmlString GetGridHtml(this HtmlHelper html, IPublishedContent contentItem, string framework, string propetyAlias, bool fluidImages)
        {
            if (fluidImages)
            {
                return html.Raw(html.GetGridHtml(contentItem, framework, propetyAlias).ToString().Replace("<img ", "<img class=\"img-fluid\" "));
            }
            else
            {
                return html.GetGridHtml(contentItem, propetyAlias, framework);
            }
        }
    }
}
