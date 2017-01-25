using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Web.Models;

namespace JacobPoldenCodes.Umbraco.Models
{
    public class BaseRenderModel : RenderModel, IMetatData
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string BodyId { get; set; }
        private BaseRenderModel(IPublishedContent content, CultureInfo culture) : base(content, culture)
        {
            Title = content.GetProperty("title").DataValue.ToString();
            Description = content.GetProperty("description").DataValue.ToString();
        }

        public BaseRenderModel(IPublishedContent content) : this(content, new CultureInfo("en-GB"))
        {
        }
    }
}