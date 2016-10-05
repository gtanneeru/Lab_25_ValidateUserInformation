using Lab_25_ValidateUserInformation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab_25_ValidateUserInformation.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ViewResult Index()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Index(Validator getResponse)
        {
            if (ModelState.IsValid)
            {
                return View("Submit", getResponse);
            }
            else
            {
                return View();
            }
        }
    }
}