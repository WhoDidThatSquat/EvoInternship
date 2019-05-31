using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shop.Web.Infrastructure;

namespace Shop.Web.Controllers
{
    public class AutentificationController : Controller
    {
        [HttpPost]
        public ActionResult Login(string userName, string password,string Role)
        {
            User user  = LoginRepository.GetUserByName(userName);

            if (user == null || user.Password.ToString() != password)
            {
              
                ViewBag.message = "Parola sau Nume incorect!";

                return View("Login");
            }
            else
            {
              
                return RedirectToAction("Index", "Home");
            }
        }

        public ActionResult Login()
        {
            return View();
        }
       
    }
}