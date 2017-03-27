using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JacobPoldenCodes.Umbraco.Models
{
    public class Navigation : List<Link>
    {
    }

    public class Link
    {
        public string Url { get; set; }
        public string Title { get; set; }
        public bool CurrentPage { get; set; }
    }
}