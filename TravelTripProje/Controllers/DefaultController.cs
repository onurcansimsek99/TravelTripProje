using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Siniflar;

namespace TravelTripProje.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        Context c = new Context();
        public ActionResult Index()
        {

            var degerler = c.Blogs.ToList();
            return View(degerler);
        }

        public ActionResult About()
        {
            return View();
        }

        public PartialViewResult Partial1()
        {
            var degerler = c.Blogs.OrderByDescending(x => x.ID).Take(2).ToList();         // Z' den A' ya sırala ve 2 değeri al, listele.
            return PartialView(degerler);
        }

        public PartialViewResult Partial2()
        {
            var deger = c.Blogs.Where(x => x.ID == 1).ToList();
            return PartialView(deger);
        }

    }
}