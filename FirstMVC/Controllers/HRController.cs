using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstMVC.Models;

namespace FirstMVC.Controllers
{
    public class HRController : Controller
    {
        // GET: HR

        //3. calling another view and passing the collection model object
        public ActionResult Index()
        {
            List<Department> dList = new List<Department>()
            {
                new Department{ Id= 1, DeptName="CSE"},
                new Department{Id=2, DeptName="ECE"},
                new Department{ Id= 3, DeptName="IT"},
                new Department{Id=4, DeptName="EEE"},
            };
            return View("DepartmentList", dList);
        }

        //the receiving view
        public ActionResult DepartmentList(List<Department> d)
        {
            return View(d);
        }

        //1. binding a model object to a view
        public ActionResult DisplayEmployee()
        {
            Employee employee = new Employee() { ID = 1, Name = "Rahul", Age = 21 };
            return View(employee);  //passing a model object of type Employee
        }

        //2. binding a collection model object to a view
        public ActionResult EmployeeList()
        {
            List<Employee> emplist = new List<Employee>()
            {
                new Employee{ID= 10, Name="Nagamani", Age=21},
                new Employee{ID=11, Name="Monika",Age=20},
                new Employee {ID=12, Name="Logesh",Age=21}
            };
            return View(emplist);
        }

        //4. To change the name of the view different from action method name
        //4.1 we can give action name selector and map it to different view name

        //4.2 We can change the view name to suit the action name
        [ActionName("Test")]
        public ActionResult DifferentViewName()
        {
            ViewBag.sample = "Testing Views with different names";
            ViewData["mydata"] = "view data value";
            //   return View("DifferentViewName");  //4.1
            return View();   //4.2
        }
    }
}