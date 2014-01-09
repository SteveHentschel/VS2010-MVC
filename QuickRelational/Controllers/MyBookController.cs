using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QuickRelational.Models;

namespace QuickRelational.Controllers
{ 
    public class MyBookController : Controller
    {
        private QuickRelationalContext db = new QuickRelationalContext();

        //
        // GET: /MyBook/

        public ViewResult Index()
        {
            var books = db.Books.Include(b => b.Author);
            return View(books.ToList());
        }

        //
        // GET: /MyBook/Details/5

        public ViewResult Details(int id)
        {
            Book book = db.Books.Find(id);
            return View(book);
        }

        //
        // GET: /MyBook/Create

        public ActionResult Create()
        {
            ViewBag.AuthorId = new SelectList(db.MyAuthors, "AuthorId", "Name");
            return View();
        } 

        //
        // POST: /MyBook/Create

        [HttpPost]
        public ActionResult Create(Book book)
        {
            if (ModelState.IsValid)
            {
                db.Books.Add(book);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            ViewBag.AuthorId = new SelectList(db.MyAuthors, "AuthorId", "Name", book.AuthorId);
            return View(book);
        }
        
        //
        // GET: /MyBook/Edit/5
 
        public ActionResult Edit(int id)
        {
            Book book = db.Books.Find(id);
            ViewBag.AuthorId = new SelectList(db.MyAuthors, "AuthorId", "Name", book.AuthorId);
            return View(book);
        }

        //
        // POST: /MyBook/Edit/5

        [HttpPost]
        public ActionResult Edit(Book book)
        {
            if (ModelState.IsValid)
            {
                db.Entry(book).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.AuthorId = new SelectList(db.MyAuthors, "AuthorId", "Name", book.AuthorId);
            return View(book);
        }

        //
        // GET: /MyBook/Delete/5
 
        public ActionResult Delete(int id)
        {
            Book book = db.Books.Find(id);
            return View(book);
        }

        //
        // POST: /MyBook/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            Book book = db.Books.Find(id);
            db.Books.Remove(book);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}