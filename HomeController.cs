using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCFirstDemo.Controllers
{
    public class HomeController : Controller
    {
        //Default View
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

        public ActionResult Greet(string id)
        {
            ViewBag.username = id;
            //return Content("Hello " + id);
            return View();
        }

        [HttpPost]
        public ActionResult Greet(int no1,int no2)
        {
            int ans = no1 + no2;
            return Content(ans.ToString());
            //return Content("Hello " + username);
        }

        public ActionResult Login()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Login(string username,string password)
        {
            if (username=="abc" && password=="abc")
            {
                // string id = username;
                return RedirectToAction("Greet",new {id=username});
                
                
            }
            return View();
        }



    }
}