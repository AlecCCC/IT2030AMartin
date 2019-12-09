using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCMusicStoreApplication.Models;

namespace MVCMusicStoreApplication.Controllers
{
    public class StoreController : Controller
    {
        private MVCMusicStoreApplicationDB db = new MVCMusicStoreApplicationDB();
        // GET: Store
        [HttpGet]
        public ActionResult Browse()
        {
            return View(db.Genres.ToList());
        }

        [HttpGet]
        public ActionResult Index(int id)
        {

            //var album = db.Albums.Find(id);
            return View(db.Albums.ToList());
        }

        public ActionResult Details(int id)
        {
            var album = db.Albums.Find(id);
            return View(album);

        }


    }
}