using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using myApp.Models;

namespace myApp.Controllers
{
    public class EmployeeController : Controller
    {
        //
        // GET: /Employee/

        public ActionResult Index()
        {
          //  List<Employee> emp = new List<Employee>() { new Employee { Ename = "balaj", depID = 111, salary = 50000 }, new Employee { Ename = "karthi", depID = 112, salary = 50000 } };
            EmployeeContext eCont = new EmployeeContext();
            List<Employee> emp = new List<Employee>();
           emp = eCont.employee.Select(x=>x).ToList();
            return View(emp);
        }

        public ActionResult Details(int id)
        {
            EmployeeContext eCont = new EmployeeContext();
            Employee emp = new Employee();
            emp = eCont.employee.Where(x => x.Eid==id).Single();
            return View(emp);
        }
    }
}
