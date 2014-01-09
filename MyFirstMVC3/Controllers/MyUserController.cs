using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyFirstMVC3.Models;

namespace MyFirstMVC3.Controllers
{
    public class MyUserController : Controller
    {
        //
        // GET: /MyUser/
        public ActionResult MyIndex()
        {
            var model = MyUserRepo.MyUsers;
            return View(model);
        }
        //
        // GET: /MyUser/MyDetails/5
        public ActionResult MyDetails(int id)
        {
            var model = MyUserRepo.MyUsers.First(user => user.UserID == id);
            return View(model);
        }
        //
        // GET: /MyUser/MyEdit/5
        public ActionResult MyEdit(int id)
        {
            var model = MyUserRepo.MyUsers.First(user => user.UserID == id);
            return View(model);
        }
        //
        // POST: /MyUser/MyEdit/5
        [HttpPost]
        public ActionResult MyEdit(int id, FormCollection collection)
        {
            var model = MyUserRepo.MyUsers.First(user => user.UserID == id);

            try
            {
                UpdateModel(model);
                return RedirectToAction("MyIndex");
            }
            catch
            {
                ModelState.AddModelError("Country", "Sample explicit validation for the 'Country' input");
                return View(model);
            }
        }
        //
        // GET: /MyUser/MyCreate
        public ActionResult MyCreate()
        {
            ViewBag.msg = "Viewbag message from create.";
            return View();
        }
        //
        // POST: /MyUser/MyCreate
        [HttpPost]
        public ActionResult MyCreate(FormCollection collection)
        {
            try
            {
                var user = new MyUser();
                UpdateModel(user);
                MyUserRepo.MyUsers.Add(user);
                // Add some SQL INSERT logic here if using permanent storage
                return RedirectToAction("MyIndex");
            }
            catch
            {
                return View();
            }
        }
        //
        // POST/GET: /MyUser/MySearch
        public ActionResult MySearch(bool? active, int? rating)
        {
            var model = MyUserRepo.MyUsers.Where(user => user.IsActive == active && user.Rating >= rating);
            return View("MyIndex", model);   // Sets view to MyIndex so as not to default to MySearch (no view created)
        }

        //
        // GET: /MyUser/MyDelete/5
        public ActionResult MyDelete(int id)
        {
            var model = MyUserRepo.MyUsers.First(user => user.UserID == id);
            return View(model);
        }

        //
        // POST: /MyUser/MyDelete/5
        [HttpPost]
        public ActionResult MyDelete(int id, FormCollection collection)
        {
            var model = MyUserRepo.MyUsers.First(user => user.UserID == id);
            MyUserRepo.MyUsers.Remove(model);
            //  Add some SQL DELETE code here if using database (permanent storage)
            return RedirectToAction("MyIndex");
        }

        //  Testing URL Search String (by name)  Format = /MyUser/SearchName?keyword=blah  (not so good)
        public ActionResult SearchName(string keyword)
        {
            var model = MyUserRepo.MyUsers.Where(user => user.Name.Contains(keyword));
            return View("MyIndex", model);
        }
    }
}
