using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JacobPoldenCodes.Umbraco.Models;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;

namespace JacobPoldenCodes.Umbraco.Controllers
{
    public class CurriculumVitaeController : RenderMvcController
    {
        public override ActionResult Index(RenderModel model)
        {
            var cv = new CurriculumVitaeRenderModel(model.Content);
            return base.Index(cv);
        }
    }
}