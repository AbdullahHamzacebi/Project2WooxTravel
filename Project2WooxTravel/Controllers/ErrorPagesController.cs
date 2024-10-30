using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project2WooxTravel.Controllers
{
    public class ErrorPagesController : Controller
    {
        // GET: ErrorPages
        // 404 hatası : sayfaya ulaşılamıyor.
        // 403 hatası : rol bazlı erişim izni hatası
        // 500 hatası : sunucu kaynaklı hata
        public ActionResult Page404()
        {
            return View();
        }
    }
}