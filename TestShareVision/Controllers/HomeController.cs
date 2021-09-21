using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestShareVision.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HttpGet]
        public ActionResult Test(bool returnNum)
        {
            int _returnNum = 0;

            if (returnNum)
                _returnNum = 1;

            return Json(new { success = true, _returnNum},
                JsonRequestBehavior.AllowGet);
        }

    }
}