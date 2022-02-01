using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission4ASP.Models;
using static Mission4ASP.Models.MoviesResponse;
using Microsoft.EntityFrameworkCore;

namespace Mission4ASP.Controllers
{
    public class HomeController : Controller
    {
        private MovieEnterContext daContext { get; set; }

        // Constructor
        public HomeController(MovieEnterContext someName)
        {
            daContext = someName;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult EnterMovie()
        {
            ViewBag.Categories = daContext.Categories.ToList();

            return View();
        }

        [HttpPost]
        public IActionResult EnterMovie(MoviesResponse ar)
        {
            if (ModelState.IsValid)
            { 
                daContext.Add(ar);
                daContext.SaveChanges();

                return View("Confirmation", ar);
            }
            // If Invalid
            else
            {
                ViewBag.Categories = daContext.Categories.ToList();

                return View();
            }
        }

        public IActionResult Podcasts()
        {
            return View();
        }

        // ENTRIES CRUD
        public IActionResult AllEntries()
        {
            var entries = daContext.Entries
                .Include(x => x.Category)
                .OrderBy(x => x.Title)
                .ToList();

            return View(entries);
        }

        [HttpGet]
        public IActionResult Edit(int movieid)
        {
            ViewBag.Majors = daContext.Categories.ToList();

            var entry = daContext.Entries.Single(x => x.MovieID == movieid);

            return View("EnterMovie", entry);
        }

        [HttpPost]
        public IActionResult Edit(MoviesResponse blah)
        {
            daContext.Update(blah);
            daContext.SaveChanges();

            return RedirectToAction("AllEntries");
        }

        [HttpGet]
        public IActionResult Delete(int movieid)
        {
            var entry = daContext.Entries.Single(x => x.MovieID == movieid);

            return View(entry);
        }

        [HttpPost]
        public IActionResult Delete(MoviesResponse ar)
        {
            daContext.Entries.Remove(ar);
            daContext.SaveChanges();

            return RedirectToAction("AllEntries");
        }
    }
}