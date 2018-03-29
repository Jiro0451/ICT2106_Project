using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExploreCalifornia.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ExploreCalifornia.DAL;
using ExploreCalifornia.Additional;

namespace ExploreCalifornia.Controllers
{
    public class ToursController : Controller
    {
        private readonly AppLogCreator _DL;

        public ToursController(IAppLogCreator dl)
        {
            _DL = (AppLogCreator) dl;
        }

        private TourGateway tourGateway = new TourGateway();

        // GET: Tour
        public ActionResult Index()
        {
            _DL.AddLog(this, "Index", DateTime.Now);
            return View(tourGateway.SelectAll());
        }

        // GET: Tour/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Tour/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tour/Create
        [HttpPost]
        public async Task<IActionResult> Create ([Bind("Id,Name,Description,Length,Price,Rating,IncludesMeals")] Tours tours)
        {
            
            if (ModelState.IsValid)
            {
                tourGateway.Insert(tours);
                return RedirectToAction(nameof(Confirm), tours);
            }
            return View(tours);
        }

        // GET: Tour/Confirm
        public ActionResult Confirm(Tours inputTour)
        {
            return View(inputTour);
        }

        // GET: Tour/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Tour/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, [Bind("Id,Name,Description,Length,Price,Rating,IncludesMeals")] Tours tours)
        {
            try
            {
                // TODO: Add update logic here
                tourGateway.Update(tours);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Tour/Delete/5
        public ActionResult Delete(int id)
        {

            return View();
        }

        // POST: Tour/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                tourGateway.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}