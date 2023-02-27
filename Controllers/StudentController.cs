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
    public class StudentController : Controller
    {
        private readonly ACE42023Context db;
        public StudentController(ACE42023Context _db)
        {
            db=_db;
        }
        public IActionResult showBooks()
        {
            string str = HttpContext.Session.GetString("Type");
            if(str!="student")
            return RedirectToAction("Index","Home");
            return View(db.BookColleges);
        }
        [HttpPost]
        public IActionResult showBooks(IFormCollection f)
        {
            string str = HttpContext.Session.GetString("Type");
            if(str!="student")
            return RedirectToAction("Index","Home");
            string keyword=f["keyword"].ToString();
            var u = db.BookColleges.Where(x=>x.BookName.Contains(keyword)).ToList();
            return View(u);
        }
        public IActionResult myBooks()
        {
            string str = HttpContext.Session.GetString("Type");
            string student = HttpContext.Session.GetString("Email");
            if(str!="student")
            return RedirectToAction("Index","Home");
            var u = db.BookColleges.Where(x=>x.IssuedTo==student).ToList();
            return View(u);
        }
        [HttpPost]
        public IActionResult myBooks(IFormCollection f)
        {
            string str = HttpContext.Session.GetString("Type");
            string student = HttpContext.Session.GetString("Email");
            if(str!="student")
            return RedirectToAction("Index","Home");
            string keyword=f["keyword"].ToString();
            var u = db.BookColleges.Where(x=>x.IssuedTo==student  && x.BookName.Contains(keyword)).ToList();
            return View(u);
        }
    }
}