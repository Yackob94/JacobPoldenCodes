using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Web;

namespace JacobPoldenCodes.Umbraco.Helpers
{
    public static class ImageHelper
    {
        public static string ImageResizerUrl(string relativeImagePath, int? height = null,
            int? width = null) => $"{relativeImagePath}?height={height}&width={width}";

        public static string ImageResizerUrl(this UmbracoHelper helper, string relativeImagePath, int? height = null,
            int? width = null) => ImageResizerUrl(relativeImagePath, height, width);

    }
}