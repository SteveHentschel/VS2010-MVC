using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC3_DBfirst.Models;

namespace MVC3_DBfirst.Controllers
{
    public class MyBlogsController : Controller
    {
        //
        // GET: /MyBlogs/

        public ActionResult Index()
        {
            using (var db = new BlogDataEntities())
            {
                return View(db.Blogs.ToList());
            }
        }

        //
        // GET: /MyBlogs/Details/5

        public ActionResult Details(int id)
        {
            using (var db = new BlogDataEntities())
            {
                return View(db.Blogs.Find(id));
            }
        }

        //
        // GET: /MyBlogs/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /MyBlogs/Create

        [HttpPost]
        public ActionResult Create(Blog blog)
        {
            try
            {
                using (var db = new BlogDataEntities())
                {
                    db.Blogs.Add(blog);
                    db.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        
        //
        // GET: /MyBlogs/Edit/5
 
        public ActionResult Edit(int id)
        {
            using (var db = new BlogDataEntities())
            {
                return View(db.Blogs.Find(id));
            }
        }

        //
        // POST: /MyBlogs/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, Blog blog)
        {
            try
            {
                using (var db = new BlogDataEntities())
                {
                    db.Entry(blog).State = System.Data.EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /MyBlogs/Delete/5
 
        public ActionResult Delete(int id)
        {
            using (var db = new BlogDataEntities())
            {
                return View(db.Blogs.Find(id));
            }
        }

        //
        // POST: /MyBlogs/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, Blog blog)
        {
            try
            {
                using (var db = new BlogDataEntities())
                {
                    db.Entry(blog).State = System.Data.EntityState.Deleted;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch
            {
                return View();
            }
        }
    }
}
