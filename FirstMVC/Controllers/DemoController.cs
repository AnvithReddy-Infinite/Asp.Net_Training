using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstMVC.Models;

namespace FirstMVC.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index()
        {
            return View();
        }

        //1. Normal method
        public string NormalMethod()
        {
            return "Hi All.. Welcome to MVC";
        }

        //2. viewresult

        public ViewResult ViewMethod()
        {
            return View();
        }

        //3. Contentresult
        public ContentResult ContentMethod()
        {
            //  return Content("Hello All!! this is the content", "text/plain");

            return Content("<h1 style=color:blue;> Good Evening to All</h1>");
        }

        //4. emptyresult

        [NonAction]
        public EmptyResult EmptyMethod()
        {
            int amt = 45000;
            float si = (amt * 3 * 2) / 100;
            return new EmptyResult();
        }

        //5. Redirect
        public ActionResult redirectMethod()
        {
            //  return RedirectToAction("ContentMethod"); //redirecting to other action method
            //of the same controller

            return RedirectToAction("index", "home"); //redirecting to other action method
                                                      //of different controller
        }

        //6. json result
        public JsonResult JsonMethod()
        {
            Employee emp = new Employee() { Id= 101, Name="Sairam", Age=22 };

            return Json(emp, JsonRequestBehavior.AllowGet);
        }

        //to check if the tempdata values are available here from the previous controllers multiple requests
        public ActionResult Test_TempData_across_controllers()
        {
            TempData.Keep();
            return View(TempData["stores"]);
        }


        //this action method is to test the tempdata values being made
        //available even after traversing many requests, and without redirection
        public ActionResult CheckTempdata()
        {
            TempData.Keep();
            return View(TempData["stores"]);
        }
    }
}