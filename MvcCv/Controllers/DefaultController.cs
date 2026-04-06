using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCv.Models.Entity;

namespace MvcCv.Controllers
{
    [AllowAnonymous]
    public class DefaultController : Controller
    {

        // GET: Default
      
        DbCvEntities db = new DbCvEntities();
        public ActionResult Index()
        {
            var degerler = db.TblHakkimda.ToList();
            return View(degerler);
        }
        public PartialViewResult Deneyim() 
        {
            var deneyimler = db.TblDeneyimlerim.ToList();
            return PartialView(deneyimler);

        }
        public PartialViewResult Egitimlerim()
        {
            var egitim = db.TblEgitimlerim.ToList();
            return PartialView(egitim);

        }
        public PartialViewResult Hobilerim()
        {
            var hobi = db.TblHobilerim.ToList();
            return PartialView(hobi);

        }
       
        public PartialViewResult Sertifikalar()
        {
          var sertifika  = db.TblSertifikalarim.ToList();
            return PartialView(sertifika);

        }
        public PartialViewResult Yeteneklerim()
        {
            var yetenek = db.TblYeteneklerim.ToList();
            return PartialView(yetenek);

        }
        [HttpGet]
        public PartialViewResult iletisim()
        {
            var iletisim = db.Tbliletisim.ToList();
            return PartialView(iletisim);

        } 

        [HttpPost] 
        public PartialViewResult iletisim(Tbliletisim t)
        {
            t.Tarih=DateTime.Parse(DateTime.Now.ToString());
            db.Tbliletisim.Add(t);
            db.SaveChanges();
            return PartialView(t);
        }

        
        public PartialViewResult SosyalMedya()
        {
            var sosyalmedya = db.TblSosyalMedya.ToList();
            return PartialView(sosyalmedya);
        }



    }
}