using System.Web;

namespace CleanBlog.Core.Helpers
{
    public static class QueryStringHelper
    {
        public static int GetIntFromQueryString(HttpRequestBase request, string key, int fallbackValue)
        {
            var stringValue = request.QueryString[key];
            return !string.IsNullOrWhiteSpace(stringValue) && int.TryParse(stringValue, out var numericValue) ? numericValue : fallbackValue;
        }
    }
}
