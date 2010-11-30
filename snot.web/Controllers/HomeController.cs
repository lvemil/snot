using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using snot.model;

namespace snot.web.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewData["notes"] = MockFactory.LoadNotes();

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
