using Lab_25_ValidateUserInformation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab_25_ValidateUserInformation.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Welcome To Sign-Up Sheet";
        }
        [HttpGet]
        public ActionResult dataInput()
        {
            if (ModelState.IsValid)
            {
                
            }
            return View();
        }
      
    }
}