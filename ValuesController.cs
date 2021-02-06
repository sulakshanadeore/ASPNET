using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIIntro.Models;

namespace WebAPIIntro.Controllers
{
    public class ValuesController : ApiController
    {
         static List<Employee> list = new List<Employee>();
        // GET api/values

        public IEnumerable<Employee> GetEmployees()
        {

            list.Add(new Employee { Empid = 1, Ename = "Ramesh" });
            list.Add(new Employee { Empid = 2, Ename = "Suresh" });
            list.Add(new Employee { Empid = 3, Ename = "Hemant" });
            return list;

            //return new string[] { "value1", "value2" };
        }


        




        // GET api/values/5
        public Employee Get(int id)
        {
            Employee empdata=list.Find(emp => emp.Empid == id);
            return empdata;
            //return "value";
        }

        // POST api/values
        public void Post([FromBody]Employee value)
        {
            list.Add(value);

        }

        // PUT api/values/5--Update
        public void Put(int id, [FromBody]Employee value)
        {
            Employee empdata = list.Find(emp => emp.Empid == id);
            empdata.Ename = value.Ename;
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            Employee empdata = list.Find(emp => emp.Empid == id);
            list.Remove(empdata);
        }
    }
}
