using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Web;

namespace JacobPoldenCodes.Umbraco.Models
{
    public class BlogRenderModel : BaseRenderModel
    {
        public List<BlogPost> BlogPosts { get; set; }
        public BlogRenderModel(IPublishedContent content) : base(content)
        {
            BlogPosts = new List<BlogPost>();
        }
    }
}