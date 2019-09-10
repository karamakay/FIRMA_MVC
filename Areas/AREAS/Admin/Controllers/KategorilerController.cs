using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FIRMA_MVC.Models;

namespace FIRMA_MVC.Controllers
{
    public class KategorilerController : Controller
    {
        FIRMAMODEL db = new FIRMAMODEL();
        // GET: Kategoriler
        public ActionResult Index(String arama)
        {
            //var liste = db.KATEGORIs.ToList();
            List<KATEGORI> liste = new List<KATEGORI>();
            if (arama==null)
            {
                arama = "";
               liste = db.KATEGORIs.ToList();

            }
            else
            {
             liste = db.KATEGORIs.Where(k => k.KATEGORI_ADI.Contains(arama)).ToList();


            }
            ViewData["veri"] = arama;



            return View(liste);
        }
        public ActionResult Sil(int id)
        {

            KATEGORI k = db.KATEGORIs.Find(id);
            if (k!=null)
            {
                db.KATEGORIs.Remove(k);
                db.SaveChanges();

            }
            return RedirectToAction("Index");

        }
        [HttpGet]
        public ActionResult Create(int? id)
        {
            if (id==null)
            {
                KATEGORI k = new KATEGORI();
                return View(k);
            }
            else
            {
                KATEGORI k = db.KATEGORIs.Find(id);
                return View(k);
            }
        }
        [HttpPost]
        public ActionResult Create(KATEGORI k)
        {
            if (k.KATEGORI_REFNO==0)
            {
                db.KATEGORIs.Add(k);
            }
            else
            {
                db.Entry(k).State = System.Data.Entity.EntityState.Modified;
            }
            db.SaveChanges();

            return RedirectToAction("Index");


        }
        public ActionResult Search(string txtAra)
        {
            //List<KATEGORI> liste = db.KATEGORIs.Where(k => k.KATEGORI_ADI.Contains(txtAra)).ToList();
            //return View("Index",liste);
            return RedirectToAction("Index", "Kategoriler", new { arama=txtAra});

        }

    }
}