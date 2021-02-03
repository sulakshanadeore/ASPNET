using MVCFirstDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCFirstDemo.Controllers
{
    public class CustomerMgtController : Controller
    {
        static List<Customer> customers = new List<Customer>();
        //{
        //    new Customer { CustomerID = 1, CustomerName = "Ana" },
        // new Customer   { CustomerID = 2, CustomerName = "sunita" }

        //};

        static CustomerMgtController()
        {
            customers.Add(new Customer { CustomerID = 1, CustomerName = "Ana",Rating=4,City="Pune" });
            customers.Add(new Customer { CustomerID = 2, CustomerName = "sunita",Rating=4,City="Mumbai" });
            customers.Add(new Customer { CustomerID = 3, CustomerName = "Keshav",Rating=5,City="Bangalore" });
            customers.Add(new Customer { CustomerID = 4, CustomerName = "Kedar",Rating=3,City="Hyderabad" });
        }
        // GET: CustomerMgt
        public ActionResult Index()
        {
            //list

            return View(customers);
        }

        public ActionResult InsertCustomer()
        {

            return View();
        }

        [HttpPost]
        public ActionResult InsertCustomer(Customer customer)
        {
            customers.Add(customer);
            return RedirectToAction("Index");
        }

        public ActionResult Update(int id)
        {
            Customer c1 = customers.Find(cust => cust.CustomerID == id);
            return View(c1);
        }

        [HttpPost]
        public ActionResult Update(Customer c)
        {
            Customer c1 = customers.Find(cust => cust.CustomerID == c.CustomerID);
            c1.CustomerName = c.CustomerName;
            c1.City = c.City;
            c1.Rating = c.Rating;
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            Customer c1 = customers.Find(cust => cust.CustomerID == id);
            ViewBag.recordCount = customers.Count-1;
            return View(c1);
        }

        [HttpPost]
        public ActionResult Delete(Customer c)
        {
            Customer data=customers.Find(c1 => c1.CustomerID == c.CustomerID);
            customers.Remove(data);

            return RedirectToAction("Index");
        }

        public ActionResult CustomerDetails(int id)
        {
            Customer c1 = customers.Find(cust => cust.CustomerID == id);
            return View(c1);
        }

    }
}