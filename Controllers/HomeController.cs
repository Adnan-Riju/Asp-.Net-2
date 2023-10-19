using AR.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using System.Xml.Linq;

namespace AR.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Name = "MD Adnan Ahamed";
            ViewBag.Id = "ID : 20-42896-1";
            ViewBag.Email = "adnanriju25@gmail.com";
            ViewBag.Contact_no = "01645877240";

            return View();
        }
        public ActionResult Dashboard()
        {
            ViewBag.Name = "MD Adnan Ahamed";
            ViewBag.Id = "ID : 20-42896-1";
            ViewBag.Email = "adnanriju25@gmail.com";
            ViewBag.Contact_no = "01645877240";



            return View();
        }


        public ActionResult Education()
        {
            ViewBag.Bsc = new string[] { "Institute", "Result", "Year" };
            ViewBag.Hsc = new string[] { "Institute", "Result", "Year" };
            ViewBag.Ssc = new string[] { "Institute", "Result", "Year" };
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

        public ActionResult Company()
        {
            Company c = new Company()
            {
                Name = "Adnan Ahamed",
                Address = "AIUB",
                Email = "adnanriju@aiub.edu",
                Descr = "Student , CSE"
            };

            return View(c);
        }
        public ActionResult Projects()
        {
            var p = new Projects()
            {
                Name = "OOP1",
                Client = "SMMS",
                Email = "Shopping Mall Management System",
                
            };
            var p1 = new Projects()
            {
                Name = "OOP2",
                Client = "RMS",
                Email="Restuarent Management System"
            };
            var p2 = new Projects()
            {
                Name = "Web Technology",
                Client = "BMS",
                Email = "Banking Management System"
            };


            var projects = new Projects[] { p, p1,p2};
            return View(projects);

            
        }
    }
}
