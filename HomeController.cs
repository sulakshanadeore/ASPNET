using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemoForPartialViewsValidations.Controllers
{
    public class HomeController : Controller
    {
        [ChildActionOnly]
        public ActionResult Greeting()
        {
            //ViewBag.Data = "this is how u use partial views";
            return PartialView("_GreetingView");
        }

        public ActionResult CustomerHome()
        {

            return View();
        }

        [HttpPost]
        public ActionResult CustomerHome(string data)
        {
            string s=doSomething(data);
            ViewBag.ReturnedData = s;
            return View();
        }

        [NonAction]
        public string doSomething(string data)
        {
           return data.Length.ToString();
        }

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
    }
}