using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JacobPoldenCodes.Umbraco.Models;
using Umbraco.Web;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;

namespace JacobPoldenCodes.Umbraco.Controllers
{
    public class BlogController : RenderMvcController
    {
        public override ActionResult Index(RenderModel model)
        {
            var blog = new BlogRenderModel(model.Content);

            foreach (var blogPost in model.Content.Children)
            {
                var postToAdd = new BlogPost
                {
                    Date = blogPost.GetPropertyValue<DateTime>("date"),
                    Description = blogPost.GetPropertyValue<string>("description"),
                    Title = blogPost.GetPropertyValue<string>("title"),
                    Url = blogPost.Url
                };

                if (blogPost.HasValue("thumbnail"))
                {
                    postToAdd.ThumbnailUrl =
                        $"/ImageGen.ashx?image={Umbraco.TypedMedia(blogPost.GetPropertyValue<int>("thumbnail")).Url}&width=300&constrain=true ";
                }

                blog.BlogPosts.Add(postToAdd);
            }

            return base.Index(blog);
        }
    }
}