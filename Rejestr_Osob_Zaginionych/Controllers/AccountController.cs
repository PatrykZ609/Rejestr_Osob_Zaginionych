using Rejestr_Osob_Zaginionych.Models;
using Rejestr_Osob_Zaginionych.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Rejestr_Osob_Zaginionych.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        private StoreContext _context;

        public AccountController()
        {
            _context = new StoreContext();
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(User user)
        {
            if (!ModelState.IsValid)
                return View("Register", user);

            if(_context.Users.Where(u => u.Email == user.Email || u.UserName == user.UserName).Any())
            {
                ModelState.AddModelError("Email", "Ten email lub nazwa użytkownia została już wcześniej użyta.");
                return View("Register", user);
            }

            _context.Users.Add(user);
            _context.SaveChanges();

            return Content("Udało Ci się założyć konto!");
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginFromViewModel user)
        {
            if (!ModelState.IsValid)
                return View("Login", user);

            var loginUser = _context.Users.Where(u => u.UserName == user.UserName && u.Password == user.Password && u.IsActive == true).FirstOrDefault();

            if(loginUser == null)
            {
                ModelState.AddModelError("UserName", "Nazwa użytkownia lub hasło jest niepoprawne.");
                return View("Login", user);

            }
            else
            {
                Session["UserName"] = loginUser.UserName;
                return RedirectToAction("Index", "Osoba");
            }
        }

    }
}