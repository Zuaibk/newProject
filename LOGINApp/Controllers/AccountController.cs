using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LOGINApp.Models;

namespace LOGINApp.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult login(RegisterModel model)
        {
            using (var context = new OfficeEntities())
            {

                bool isValid = context.Register.Any(x => x.UserName == model.UserName && x.Password == model.Password);
            
            if ()
            }
            return View();
        }

        public ActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignUp(Register model)
        {

            using (var context = new OfficeEntities())
            {
                context.Register.Add(model);
                context.SaveChanges();
            }
            return RedirectToAction("Login");
        }

    }
}