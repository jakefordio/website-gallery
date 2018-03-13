using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebsiteGallery.Controllers
{
    public class WebsitesController : Controller //Controller Classes must be public to access in URL
    {
        public ActionResult Project() //Controller ACTION METHODS must also be public to access in URL
        {
            //if(DateTime.Today.DayOfWeek == DayOfWeek.Saturday)
            //{
            //    return Redirect("https://jakeford.us");
            //}
            //return Content("WHAT UP MY NIGGA");
            ViewBag.ProjectTitle = "Shoals <strong>TRAC</strong>";
            ViewBag.Screenshot = "";
            ViewBag.Requirements = new String[]
            {
                "Modern Design",
                "Responsive",
                "User Friendly",
                "Self-Updated"
            };
            ViewBag.Technologies = new String[]
            {
                "WordPress",
                "Bootstrap 4",
                "HTML5",
                "CSS3",
                "Javascript",
                "PHP"
            };
            return View();
        }
    }
}