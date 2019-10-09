using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FIRMA_MVC.Models;

namespace FIRMA_MVC.Areas.AREAS.Admin.Controllers
{
    public class UrunlerController : Controller
    {
        FIRMAMODEL db = new FIRMAMODEL();
        // GET: AREAS/Urunler
        public ActionResult Index()
        {
            List<URUN> liste = db.URUNs.ToList();
            return View();
        }
    }
}