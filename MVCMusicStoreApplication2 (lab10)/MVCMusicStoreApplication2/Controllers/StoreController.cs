using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVCMusicStoreApplication2.Models;

namespace MVCMusicStoreApplication.Controllers
{
    public class StoreController : Controller
    {

        private MVCMusicStoreDB db = new MVCMusicStoreDB();

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
        public ActionResult Browse()
        {
            return View();
        }
    }
}