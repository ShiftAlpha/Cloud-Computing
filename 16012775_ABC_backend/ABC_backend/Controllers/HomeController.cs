using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ABCTask2
{
    public class HomeController : Controller
    {
        //returns index navigation
        public ActionResult Index()
        {
            return View();
        }
        //redirects user 
        public ActionResult Feedback(String message, bool isSuccess, String redirectControl, String redirectAction)
        {
            if (redirectControl != null && redirectAction != null)
            {
                ViewBag.RedirectControl = redirectControl;
                ViewBag.RedirectAction = redirectAction;
            }
           
            ViewBag.Title = "Success";
            if (!isSuccess)
            {
                ViewBag.Title = "Failed";
            }
            ViewBag.Message = message;
            //returns view class
            return View();
        }

    }


}