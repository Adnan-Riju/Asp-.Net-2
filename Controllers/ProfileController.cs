using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AR.Models;
namespace AR.Controllers
{
    public class ProfileController : Controller
    {
        // GET: Profile
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Signup()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Signup(SignUpModel signup)
        {

            // ViewBag.name = fc["UserName"];
            //ViewBag.email = fc["Email"];
            //ViewBag.gender = fc["Gender"];
            //ViewBag.Hobbies = fc["Hobbies"];
            //ViewBag.Profession = fc["profession"];

            if (ModelState.IsValid)
            {  //all validation in submitted model
                return RedirectToAction("Index");
            }
            return View(signup);
          
        }
        
       
    }
}