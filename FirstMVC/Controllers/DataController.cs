using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVC.Controllers
{
    public class DataController : Controller
    {
        // GET: Data
        public ActionResult Index()
        {
            //1. passing an object to the view that will b used as a model
            //ViewBag.data = "Flowers List";
            //List<string> flowers = new List<string>
            //{
            //    "Roses", "Lilies","Jasmine","Marigolds"
            //};
            //return View(flowers);

            // trying to access tempdata of the earlier few requests
            List<string> stlist = TempData["stores"] as List<string>;
            // return View(stlist); able to see tempdata from previous many requests

            //redirecting to see termpdata values in sifferent controller
            return RedirectToAction("Test_TempData_across_controllers", "Demo");
        }

        //2. checking if the viewbag can pass on the data/info to further requests
        public ActionResult TestDataTransfer()
        {
            ViewBag.data1 = "Data One";

            ViewData["data2"] = "Data Two";
            return View();  // data passed to the current view

            //  return RedirectToAction("Index");
        }

        //3. passing data thru viewbag and viewdata
        public ActionResult OfficeRules()
        {
            List<string> rules = new List<string>
            {
                "Be on Time", "Carry you IDcard", "Complete work as per deadlines",
                "Avoid T-Shirts"
            };
            //3.1 transfer data thru viewbag
            ViewBag.offrules = rules;
            //return View();

            //3.2 transfer using viewdata
            ViewData["or"] = rules;
            // return View();
            return RedirectToAction("TestDataTransfer");
        }

        //4. passing data thru tempdata object
        public ActionResult FirstTempRequest()
        {
            List<string> stationeries = new List<string>()
            {
                "Pens", "Pencils","NoteBooks","Markers","Erasers"
            };

            TempData["stores"] = stationeries;

            //4.1 using tempdata in the current view
            // return View();  

            //4.2 redirecting to see if tempdata is available
            return RedirectToAction("SecondTempRequest");
        }

        public ActionResult SecondTempRequest()
        {
            //List<string> stnlist;
            //stnlist = TempData["stores"] as List<string>;
            //   return View(stnlist);
            return RedirectToAction("Index");  //making a third request to index view
        }
    }
}