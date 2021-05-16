using Rejestr_Osob_Zaginionych.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Rejestr_Osob_Zaginionych.Controllers
{
    public class WojewodztwoController : Controller
    {
        // GET: Wojewodztwo
        private StoreContext _context;

        public WojewodztwoController()
        {
            _context = new StoreContext();
        }

         
        
        
        public ActionResult Index()
        {
            var wojewodztwos = _context.Wojewodztwos.ToList();
            return View(wojewodztwos);
        }

        public ActionResult Create()
        {
            return View(new Wojewodztwo { Id = 0 });
        }
        [HttpPost]
        public ActionResult Create(Wojewodztwo _wojewodztwo)
        {
            if (!ModelState.IsValid)
                return View("Create", _wojewodztwo);

            if (_wojewodztwo.Id > 0)
                _context.Entry(_wojewodztwo).State = System.Data.Entity.EntityState.Modified;
            else
                 _context.Wojewodztwos.Add(_wojewodztwo);
            
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var wojewodztwo = _context.Wojewodztwos.SingleOrDefault(c => c.Id == id);

            if (wojewodztwo == null)
                return HttpNotFound();

            _context.Wojewodztwos.Remove(wojewodztwo);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult Edit (int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var _wojewodztwo = _context.Wojewodztwos.SingleOrDefault(c => c.Id == id);

            if (_wojewodztwo == null)
                return HttpNotFound();
            return View("Create", _wojewodztwo);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
                _context.Dispose();
            base.Dispose(disposing);
        }
    }
}