using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CMS.Models;
using Microsoft.AspNetCore.Http;

namespace CMS.Controllers
{
    public class AdminController : Controller
    {
        private readonly ACE42023Context db;
        public AdminController(ACE42023Context _db)
        {
            db=_db;
        }
        public IActionResult showAdminBooks()
        {
            string str = HttpContext.Session.GetString("Type");
            if(str!="admin")
            return RedirectToAction("Index","Home");
            return View(db.BookColleges);
        }
        [HttpPost]
        public IActionResult showAdminBooks(IFormCollection f)
        {
            string str = HttpContext.Session.GetString("Type");
            if(str!="admin")
            return RedirectToAction("Index","Home");
            string keyword=f["keyword"].ToString();
            var u = db.BookColleges.Where(x=>x.BookName.Contains(keyword)).ToList();
            return View(u);
        }
        public IActionResult addBooks()
        {
            string str = HttpContext.Session.GetString("Type");
            if(str!="admin")
            return RedirectToAction("Index","Home");
            return View();
        }
        [HttpPost]
        public IActionResult addBooks(BookCollege obj)
        {
            string str = HttpContext.Session.GetString("Type");
            if(str!="admin")
            return RedirectToAction("Index","Home");
            db.BookColleges.Add(obj);
            db.SaveChanges();
            return RedirectToAction("showAdminBooks", "Admin");
        }
        public IActionResult editBooks(int email)
        {
            string str = HttpContext.Session.GetString("Type");
            if(str!="admin")
            return RedirectToAction("Index","Home");
            // UserCollege u = db.UserColleges.Find(email);
            BookCollege u = db.BookColleges.Where(x=>x.BookId==email).SingleOrDefault();
            return View(u);
        }
        [HttpPost]
        public IActionResult editBooks(BookCollege u)
        {
            string str = HttpContext.Session.GetString("Type");
            if(str!="admin")
            return RedirectToAction("Index","Home");
            db.BookColleges.Update(u);
            db.SaveChanges();
            return RedirectToAction("showAdminBooks", "Admin");
        }
        public IActionResult deleteBooks(int email)
        {
            string str = HttpContext.Session.GetString("Type");
            if(str!="admin")
            return RedirectToAction("Index","Home");
            BookCollege e = db.BookColleges.Find(email);
            return View(e);
        }
        [HttpPost]
        [ActionName("delete")] // mvc compiler
        public IActionResult deleteConfirmedBooks(int email) // c# compiler as alternate overload
        {
            string str = HttpContext.Session.GetString("Type");
            if(str!="admin")
            return RedirectToAction("Index","Home");
            BookCollege e = db.BookColleges.Find(email);
            db.BookColleges.Remove(e);
            db.SaveChanges();
            return RedirectToAction("showAdminBooks", "Admin");
        }
        
    }
}