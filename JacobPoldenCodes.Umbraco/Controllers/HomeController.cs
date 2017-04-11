using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JacobPoldenCodes.Umbraco.Helpers;
using JacobPoldenCodes.Umbraco.Models;
using Umbraco.Web;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;

namespace JacobPoldenCodes.Umbraco.Controllers
{
    public class HomeController : RenderMvcController
    {
        public override ActionResult Index(RenderModel model)
        {
            var home = new HomeRenderModel(model.Content);
            foreach (var blogPost in Umbraco.TypedContent(1055).Children.Where("I"))
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
                        ImageHelper.ImageResizerUrl(Umbraco.TypedMedia(blogPost.GetPropertyValue<int>("thumbnail"))
                            .Url, width: 300);
                }

                home.BlogPosts.Add(postToAdd);
            }
            return base.Index(home);
        }
    }
}