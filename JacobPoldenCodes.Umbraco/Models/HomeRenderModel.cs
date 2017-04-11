using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web.Models;

namespace JacobPoldenCodes.Umbraco.Models
{
    public class HomeRenderModel : BaseRenderModel
    {
        public List<BlogPost> BlogPosts { get; set; }
        public HomeRenderModel(IPublishedContent content) : base(content)
        {
            BlogPosts = new List<BlogPost>();
        }
    }
}