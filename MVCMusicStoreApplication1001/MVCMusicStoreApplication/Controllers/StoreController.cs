using MVCMusicStoreApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCMusicStoreApplication.Controllers
{
    public class StoreController : Controller
    {
        private MVCMusicStoreDB db = new MVCMusicStoreDB();

        public ActionResult DailyDeal()
        {
            var album = GetDailyDeal();
            return PartialView("_DailyDeal", album);
        }

        private object GetDailyDeal()
        {
            var album = db.Albums
            .OrderBy(a => System.Guid.NewGuid())
             .First();
            return album;
        }



        public ActionResult GenreSearch(string q)
        {
            var Name = GetGenre(q);
            return PartialView("_GenreSearch", Name);
        }

        private List<Genre> GetGenre(string searchString)
        {
            return db.Genres
            .Where(a => a.Name.Contains(searchString))
            .ToList();
        }


        // GET: Store
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Browse()
        {
            return View();
        }
        public ActionResult Details()
        {
            return View();
        }
    }
}