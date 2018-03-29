using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using ExploreCalifornia.Models;
using Microsoft.AspNetCore.Mvc;
using ExploreCalifornia.Additional;

namespace ExploreCalifornia.Controllers
{
    public class BookingController : Controller
    {

        private readonly AppLogCreator _DL;

        public BookingController(IAppLogCreator dl)
        {
            _DL = (AppLogCreator)dl;
        }

        //Static list to be referenced
        static List<Booking> bookings = new List<Booking>();

        // GET: Tour
        public ActionResult Index()
        {
            _DL.AddLog(this, "Index", DateTime.Now);
            return View(bookings);
        }

        // GET: Tour/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tour/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Booking inputBooking)
        {
            try
            {
                // TODO: Add insert logic here
                bookings.Add(inputBooking);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
