using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StrongInlinehHTML.Models;

namespace StrongInlinehHTML.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Employee employee = new Employee()
            {
               Address = "Shivamogga",
               Name = "Vinay",
               isEmpty = true

        };
           
            return View(employee);
        }
        [HttpPost]
        public ActionResult Index(Employee employee)
        {
            return View();
        }

    }
}