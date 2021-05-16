using Rejestr_Osob_Zaginionych.Models;
using Rejestr_Osob_Zaginionych.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using System.Net;


namespace Rejestr_Osob_Zaginionych.Controllers
{
    public class OsobaWithoutLoginController : Controller
    {

        private StoreContext _context;

        public OsobaWithoutLoginController()
        {
            _context = new StoreContext();
        }
        public ActionResult Index()
        {
            var osobas = _context.Osobas.Include(c => c.Wojewodztwo).ToList();

            return View(osobas);

        }


    }
}