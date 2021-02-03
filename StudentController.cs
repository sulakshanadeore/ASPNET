using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCFirstDemo.Models;
namespace MVCFirstDemo.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            ViewBag.Message = "Jack and Jill using View Bag to send data from Controller to View";

            return View();
        }

        public ActionResult CustomerList()
        {
            Customer c = new Customer();
            c.CustomerID = 1;
            c.CustomerName = "Jack";

            Customer c1 = new Customer();
            c1.CustomerID = 2;
            c1.CustomerName = "Jill";

            Customer c2 = new Customer();
            c2.CustomerID = 3;
            c2.CustomerName = "Humpty";

            List<Customer> custlist = new List<Customer>();
            custlist.Add(c);
            custlist.Add(c1);
            custlist.Add(c2);

            ViewBag.customers = custlist;

            return View();
        }

        public ActionResult ShowCustomers()
        {

            Customer c = new Customer();
            c.CustomerID = 1;
            c.CustomerName = "Jack";

            Customer c1 = new Customer();
            c1.CustomerID = 2;
            c1.CustomerName = "Jill";

            Customer c2 = new Customer();
            c2.CustomerID = 3;
            c2.CustomerName = "Humpty";

            List<Customer> custlist = new List<Customer>();
            custlist.Add(c);
            custlist.Add(c1);
            custlist.Add(c2);
            ViewData["Message"] = "List is as follows ";
            ViewData["customers"] = custlist;
            
            return View();
        }

        public ActionResult Source()
        {
            TempData["mydata"] = "Hello from  Source";
            return RedirectToAction("Destination");

        }

        public ActionResult Destination()
        {
            TempData["receviedData"] = TempData["mydata"];
            TempData.Keep();
            TempData.Keep();
            return View();
        }

        [HttpPost]
        public ActionResult Destination(string d)
        {
            TempData["mydata"] = TempData.Peek("mydata");
            TempData["receviedData"] = TempData.Peek("receviedData");
            return RedirectToAction("showTempData");
        }
        public ActionResult showTempData()
        {
            TempData["mydata"]=TempData["mydata"];
            TempData["receviedData"] = TempData["receviedData"];

            return View();
        }


    }
}