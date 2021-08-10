using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Umbraco.Core.Models.PublishedContent;

namespace CleanBlog.Core.ViewModels
{
    public class ArticleResultSet
    {
        private IEnumerable<IPublishedContent> results;
        private int pageSize;
        private int pageNumber;
        private double pageCount;
        private bool isArticleListPage;
        private string url;



        public IEnumerable<IPublishedContent> Results { get => results; set => results = value; }
        public int PageSize { get => pageSize; set => pageSize = value; }
        public int PageNumber { get => pageNumber; set => pageNumber = value; }
        public double PageCount { get => pageCount; set => pageCount = value; }
        public bool IsArticleListPage { get => isArticleListPage; set => isArticleListPage = value; }
        public string Url { get => url; set => url = value; }
    }
}
