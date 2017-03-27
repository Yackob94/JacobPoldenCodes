﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core.Models;

namespace JacobPoldenCodes.Umbraco.Models
{
    public class BlogPostRenderModel : BaseRenderModel
    {
        public BlogPostRenderModel(IPublishedContent content) : base(content)
        {
        }
    }
}