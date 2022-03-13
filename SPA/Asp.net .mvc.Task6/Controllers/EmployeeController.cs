using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Asp.net.mvc.Task6.Models;

namespace Asp.net.mvc.Task6.Controllers
{
    public class EmployeeController : Controller
    {
        CompanySystemTask7 db = new CompanySystemTask7();
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult GetEmployee()
        {
            var emps = db.Employees.Include(e=>e.department);
            return PartialView(emps);
        }
        [HttpPost]
        public ActionResult Create(Employee emp)
        {
            db.Employees.Add(emp);
            db.SaveChanges();
            return PartialView("GetEmployee", db.Employees.Include(e => e.department));
        }
    }
}