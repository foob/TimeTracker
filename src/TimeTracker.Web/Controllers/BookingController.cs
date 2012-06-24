using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TimeTracker.Web.Data;
using TimeTracker.Web.Models;

namespace TimeTracker.Web.Controllers
{
    public class BookingController : MyControllerBase
    {
        public BookingController(IRepository repository) : base(repository)
        {
        }

        //public BookingController() : base(Repository.Default){}

        public ActionResult Index(Guid projectId)
        {
            ViewBag.Project = Repository.GetProject(projectId);

            return View(Repository.GetBookingsByProject(projectId));
        }
        
        //
        // GET: /Booking/Create

        public ActionResult Create(Guid projectId)
        {
            return View(Booking.Create(projectId));
        }

        //
        // POST: /Booking/Create

        [HttpPost]
        public ActionResult Create(Booking booking)
        {
            Repository.Add(booking);

            return RedirectToAction("Index", new { projectId = booking.ProjectId });
        }

        //
        // GET: /Booking/Edit/5

        public ActionResult Edit(Guid id)
        {
            return View(Repository.GetBooking(id));
        }

        //
        // POST: /Booking/Edit/5

        [HttpPost]
        public ActionResult Edit(Booking booking)
        {
            Repository.Update(booking);
            return RedirectToAction("Index", new { projectId = booking.ProjectId });
        }

        //
        // GET: /Booking/Delete/5

        public ActionResult Delete(Guid id)
        {
            return View(Repository.GetBooking(id));
        }

        //
        // POST: /Booking/Delete/5

        [HttpPost]
        public ActionResult Delete(Booking booking)
        {
            var redirectId = Repository.GetBooking(booking.Id).ProjectId;
            Repository.Delete(booking);

            return RedirectToAction("Index", new { projectId = redirectId });
        }
    }
}
