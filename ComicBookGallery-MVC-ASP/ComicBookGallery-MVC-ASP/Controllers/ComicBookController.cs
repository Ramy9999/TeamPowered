using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery_MVC_ASP.Controllers
{
    public class ComicBookController : Controller
    {
        public ActionResult Detail ()
        {
            if (DateTime.Today.DayOfWeek == DayOfWeek.Monday)
            {
                return Redirect("/");
            }
            return Content ("Hello this is the comic book's controller!");


        }
    }
}