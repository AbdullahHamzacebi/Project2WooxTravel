using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project2WooxTravel.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        // DbFirst'te tablolar sütunlar properties arasında  nasıl bir ilişki var :
        // Tablolar sınıf olarak dahil oluyor. Sütunlar da prop olarak dahil oluyor.
        // CodeFirst'te tam tersi prop lar sütunlara dönüşecek ardından sınıflar birer tabloya dönüşüyor olacak.
    }
}