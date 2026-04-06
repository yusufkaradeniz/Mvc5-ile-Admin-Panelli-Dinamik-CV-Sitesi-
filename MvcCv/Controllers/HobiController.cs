using MvcCv.Models.Entity;
using MvcCv.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCv.Controllers
{
    public class HobiController : Controller
    {
        // GET: Hobi
        GenericRepository<TblHobilerim> repo = new GenericRepository<TblHobilerim>();
        public ActionResult Index()
        {
            var hobiler = repo.List();
            return View(hobiler);
        }
        [HttpGet]
        public ActionResult HobiDuzenle(int id)
        {
            var hobi = repo.Find(x => x.ID == id);
            return View(hobi);
        }

        [HttpPost]
        public ActionResult HobiDuzenle(TblHobilerim t)
        {
            var h = repo.Find(x => x.ID == t.ID);
            h.Aciklama1 = t.Aciklama1;
            h.Aciklama2 = t.Aciklama2;
            repo.TUpdate(h);

            return RedirectToAction("Index");
        }
    }
}