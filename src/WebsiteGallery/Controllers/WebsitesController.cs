using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebsiteGallery.Controllers
{
    public class WebsitesController : Controller //Controller Classes must be public to access in URL
    {
        public string Detail() //Controller ACTION METHODS must also be public to access in URL
        {
            return "What up my nigga.";
        }
    }
}