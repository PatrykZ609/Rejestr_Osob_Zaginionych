using Rejestr_Osob_Zaginionych.Models;
using Rejestr_Osob_Zaginionych.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using System.Net;
using System.Data.SqlClient;
using System.Data;

namespace Rejestr_Osob_Zaginionych.Controllers
{
    public class OsobaController : Controller
    {
        private StoreContext _context;

        public OsobaController()
        {
            _context = new StoreContext();
        }

        public ActionResult Create()
        {
            var _wojewodztwos = _context.Wojewodztwos.ToList();

            var viewModel = new OsobaFromViewModel
            {
                Osoba = new Osoba(),
                Wojewodztwos = _wojewodztwos

            };

            return View(viewModel);
        }
        [HttpPost]
        //public ActionResult Create([Bind(Include="Id,Name,Nazwisko,Wiek,Płeć,Ostatnie_miejsce_pobytu,WojewodztwoId")] Osoba _osoba)
        public ActionResult Create(Osoba osoba)
        {
            _context.Osobas.Add(osoba);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        // GET: Osoba
        public ActionResult Index()
        {
            var osobas = _context.Osobas.Include(c => c.Wojewodztwo).ToList();

            return View(osobas);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var osoba = _context.Osobas.SingleOrDefault(c => c.Id == id);

            if (osoba == null)
                return HttpNotFound();

            _context.Osobas.Remove(osoba);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }



        public ActionResult Edit(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var _osoba = _context.Osobas.SingleOrDefault(p => p.Id == id);

            if (_osoba == null)
                return HttpNotFound();

            var viewModel = new OsobaFromViewModel
            {
                Osoba = _osoba,
                Wojewodztwos = _context.Wojewodztwos.ToList()

            };
            return View("Create", viewModel);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
                _context.Dispose();
            base.Dispose(disposing);
        }
    }
}