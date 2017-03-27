using System;
using System.Web;

namespace JacobPoldenCodes.Umbraco.Models
{
    public class BlogPost
    {
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public string ThumbnailUrl { get; set; }
    }
}