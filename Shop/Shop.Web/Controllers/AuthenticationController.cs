using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Shop.Web.Infrastructure;


namespace Shop.Web.Controllers
{
    public class AutentificationController : Controller
    {
        [HttpPost]
        public ActionResult Login(string userName, string password)
        {
            User user  = LoginRepository.GetUserByName(userName);

            if (user == null || user.Password.ToString() != password)
            {
                HttpContext.Session.Set("name", null);
				ViewBag.message = "Parola sau Nume incorect!";

                return View("Login");
            }
            else
            {
              
                HttpContext.Session.SetString("user", JsonConvert.SerializeObject(user));
                return RedirectToAction("Index", "Home");
              
            }
        }

        public ActionResult Login()
        {
            return View();
        }
       
    }
}
