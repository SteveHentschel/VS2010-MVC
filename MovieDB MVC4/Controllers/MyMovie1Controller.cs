using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieDB_MVC4.Models;

namespace MovieDB_MVC4.Controllers
{
    public class MyMovie1Controller : Controller
    {
        private Movie1DBContext db = new Movie1DBContext();

        //
        // GET: /MyMovie1/

        public ActionResult Index()
        {
            return View(db.Movies1.ToList());
        }

        //
        // GET: /MyMovie1/Details/5

        public ActionResult Details(int id = 0)
        {
            Movie movie = db.Movies1.Find(id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }

        //
        // GET: /MyMovie1/Create

        public ActionResult Create()
        {
            string[] ratingList = new string[] {"G", "PG", "PG-13", "R", "NC-17"};
            ViewBag.ratings = new SelectList(ratingList);

            return View();
        }

        //
        // POST: /MyMovie1/Create

        [HttpPost]
        public ActionResult Create(Movie movie)
        {
            if (ModelState.IsValid)
            {
                db.Movies1.Add(movie);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(movie);
        }

        //
        // GET: /MyMovie1/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Movie movie = db.Movies1.Find(id);

            string[] ratingList = new string[] { "G", "PG", "PG-13", "R", "NC-17" };
            ViewBag.ratings = new SelectList(ratingList);

            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }

        //
        // POST: /MyMovie1/Edit/5

        [HttpPost]
        public ActionResult Edit(Movie movie)
        {
            if (ModelState.IsValid)
            {
                db.Entry(movie).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(movie);
        }

        //
        // GET: /MyMovie1/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Movie movie = db.Movies1.Find(id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }

        //
        // POST: /MyMovie1/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Movie movie = db.Movies1.Find(id);
            db.Movies1.Remove(movie);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }

        //
        // GET: /MyMovie1/SearchIndex/5
        public ActionResult SearchIndex(string movieGenre, string searchString)
        {
            var GenreLst = new List<string>();                  // create string list to hold genres

            var GenreQry = from d in db.Movies1                 // populate list with all genres
                           orderby d.Genre
                           select d.Genre;
            GenreLst.AddRange(GenreQry.Distinct());             // remove duplicate genres
            ViewBag.movieGenre = new SelectList(GenreLst);      // add to Viewbag for passing to View

            var movies = from m in db.Movies1                   // grab all the movies to display
                         select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                movies = movies.Where(s => s.Title.Contains(searchString)); // filter based on title input
            }

            if (string.IsNullOrEmpty(movieGenre))
                return View(movies);
            else
            {
                return View(movies.Where(x => x.Genre == movieGenre));      // further filter based on genre
            }

        }
    }
}