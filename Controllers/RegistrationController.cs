using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeShop.Controllers
{
    public class RegistrationController : Controller
    {
        public IActionResult Index(int? id)
        {
            ViewData["id"] = id;
            return View("RegistrationIndex");
        }
        [HttpPost]
        public IActionResult Registration(string fname, string lname, string email, int number, string password )
        {
            ViewData["name"] = fname + " " + lname;
             return View();
        }
    }

}