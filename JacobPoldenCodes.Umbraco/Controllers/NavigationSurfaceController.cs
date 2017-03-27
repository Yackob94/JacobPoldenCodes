using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JacobPoldenCodes.Umbraco.Models;
using Umbraco.Core;
using Umbraco.Core.Models;
using Umbraco.Web.Mvc;

namespace JacobPoldenCodes.Umbraco.Controllers
{
    public class NavigationSurfaceController : SurfaceController
    {

        [ChildActionOnly]
        [HttpGet]
        public ActionResult Navigation()
        {
            var root = Umbraco.TypedContentAtRoot().First();
            var navigation = new Navigation();

            foreach (var content in root.Children)
                navigation.Add(new Link { Title = content.Name, Url = content.Url,CurrentPage = content.Id == Umbraco.UmbracoContext.PageId });

            return PartialView("_Navigation", navigation);
        }
    }
}