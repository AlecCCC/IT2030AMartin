using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EventProject.Models;

namespace EventProject.Controllers
{
    public class EventsController : Controller
    {
        private EventProjectDB db = new EventProjectDB();








        public ActionResult Register(int? id)
        {

            var events = db.Events;
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Event @event = db.Events.Find(id);
            if (@event == null)
            {
                return HttpNotFound();
            }
           
            return View(@event);

        }


        

        public ActionResult EventSearch(string q)
        {
            var eventtitle = GetEvents(q);
            return PartialView("_EventSearch", eventtitle);
        }

        private List<Event> GetEvents(string searchString)
        {
            return db.Events
            .Where(a => a.EventTitle.Contains(searchString) || a.EventType.Type.Contains(searchString))
            .ToList();
        }


        public ActionResult LocationSearch(string e)
        {
            var location = GetLocation(e);
            return PartialView("_LocationSearch", location);
        }

        private List<Event> GetLocation(string searchString)
        {
            return db.Events
            .Where(a => a.Location.Contains(searchString))
            .ToList();
        }





        // GET: Events
        public ActionResult Data()
        {
            return View(db.Events.ToList());
        }

        //Home Page
        public ActionResult Home()
        {
            return View();
        }

        //EventType
        public ActionResult EventType()
        {
            return View(db.EventTypes.ToList());
        }
        //Organize
        [Authorize]
        public ActionResult Organize()
        {
            return View();
        }

        // GET: Events/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Event @event = db.Events.Find(id);
            if (@event == null)
            {
                return HttpNotFound();
            }
            return View(@event);
        }

        // GET: Events/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Events/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EventId,EventTitle,EventDesc,StartDate,EndDate,StartTime,EndTime,Location,MaxTix,AvailableTix,EventType,OrgName,OrgEmail,OrgPhone")] Event @event)
        {
            if (ModelState.IsValid)
            {
                db.Events.Add(@event);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(@event);
        }

        // GET: Events/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Event @event = db.Events.Find(id);
            if (@event == null)
            {
                return HttpNotFound();
            }
            return View(@event);
        }

        // POST: Events/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EventId,EventTitle,EventDesc,StartDate,EndDate,StartTime,EndTime,Location,MaxTix,AvailableTix,EventType,OrgName,OrgEmail,OrgPhone")] Event @event)
        {
            if (ModelState.IsValid)
            {
                db.Entry(@event).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(@event);
        }

        // GET: Events/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Event @event = db.Events.Find(id);
            if (@event == null)
            {
                return HttpNotFound();
            }
            return View(@event);
        }

        // POST: Events/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Event @event = db.Events.Find(id);
            db.Events.Remove(@event);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
