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
    public class MyAuthorController : Controller
    {
        private QuickRelationalContext db = new QuickRelationalContext();

        //
        // GET: /MyAuthor/

        public ViewResult Index()
        {
            return View(db.MyAuthors.ToList());
        }

        //
        // GET: /MyAuthor/Details/5

        public ViewResult Details(int id)
        {
            MyAuthor myauthor = db.MyAuthors.Find(id);
            return View(myauthor);
        }

        //
        // GET: /MyAuthor/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /MyAuthor/Create

        [HttpPost]
        public ActionResult Create(MyAuthor myauthor)
        {
            if (ModelState.IsValid)
            {
                db.MyAuthors.Add(myauthor);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(myauthor);
        }
        
        //
        // GET: /MyAuthor/Edit/5
 
        public ActionResult Edit(int id)
        {
            MyAuthor myauthor = db.MyAuthors.Find(id);
            return View(myauthor);
        }

        //
        // POST: /MyAuthor/Edit/5

        [HttpPost]
        public ActionResult Edit(MyAuthor myauthor)
        {
            if (ModelState.IsValid)
            {
                db.Entry(myauthor).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(myauthor);
        }

        //
        // GET: /MyAuthor/Delete/5
 
        public ActionResult Delete(int id)
        {
            MyAuthor myauthor = db.MyAuthors.Find(id);
            return View(myauthor);
        }

        //
        // POST: /MyAuthor/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            MyAuthor myauthor = db.MyAuthors.Find(id);
            db.MyAuthors.Remove(myauthor);
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