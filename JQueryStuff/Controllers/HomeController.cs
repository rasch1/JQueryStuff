using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JQueryStuff.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Hej";

            return View();
        }

        [HttpPost]
        public ActionResult Index(HttpPostedFileBase file)
        {
            // Verify that the user selected a file
            if (file != null && file.ContentLength > 0)
            {
                // extract only the fielname
                var fileName = Path.GetFileName(file.FileName);
                // store the file inside uploads folder
                var path = Path.Combine(Server.MapPath("~/Uploads"), fileName);
                file.SaveAs(path);
            }
            // redirect back to the index action to show the form once again
            return RedirectToAction("Index");
        }


        public ActionResult About()
        {
            return View();
        }

        public ActionResult Fading()
        {
            return View();
        }
        public ActionResult SlidingPage()
        {
            return View();
        }
        public ActionResult Left()
        {
            return View("~/Views/Pages/Left.cshtml");
        }
        public ActionResult Right()
        {
            return View("~/Views/Pages/Left.cshtml");
        } 
        public ActionResult Modal()
        {
            return View("~/Views/Pages/Modal.cshtml");
        } 
        public ActionResult Font()
        {
            return View();
        }
        public ActionResult Editor()
        {
            return View();
        }
    }
}
