using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CMS.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
// using System.Web.Mvc;

namespace CMS.Controllers
{
    public class LecturerController: Controller
    {
        private readonly ACE42023Context db;
        public LecturerController(ACE42023Context _db)
        {
            db=_db;
        }
        public IActionResult showStudents()
        {
            string str = HttpContext.Session.GetString("Type");
            if(str!="lecturer")
            return RedirectToAction("Index","Home");
            return View(db.StudentColleges);
        }
        [HttpPost]
        public IActionResult showStudents(IFormCollection f)
        {
            string str = HttpContext.Session.GetString("Type");
            if(str!="lecturer")
            return RedirectToAction("Index","Home");
            string keyword=f["keyword"].ToString();
            var u = db.StudentColleges.Where(x=>x.Name.Contains(keyword)).ToList();
            return View(u);
        }
        public IActionResult createStudents()
        {
            string str = HttpContext.Session.GetString("Type");
            if(str!="lecturer")
            return RedirectToAction("Index","Home");
            return View();
        }
        [HttpPost]
        public IActionResult createStudents(StudentCollege obj)
        {
            string str = HttpContext.Session.GetString("Type");
            if(str!="lecturer")
            return RedirectToAction("Index","Home");
            db.StudentColleges.Add(obj);
            db.SaveChanges();
            return RedirectToAction("showStudents", "Lecturer");
        }
        public IActionResult detailStudents(string id)
        {
            string str = HttpContext.Session.GetString("Type");
            if(str!="lecturer")
            return RedirectToAction("Index","Home");
            // UserCollege u = db.UserColleges.Find(email);
            StudentCollege u = db.StudentColleges.Where(x=>x.Email==id).SingleOrDefault();
            if(u==null) return RedirectToAction("success");
            return View(u);
        }
        public IActionResult editStudents(string id)
        {
            string str = HttpContext.Session.GetString("Type");
            if(str!="lecturer")
            return RedirectToAction("Index","Home");
            // UserCollege u = db.UserColleges.Find(id);
            StudentCollege u = db.StudentColleges.Where(x=>x.Email==id).SingleOrDefault();
            return View(u);
        }
        [HttpPost]
        public IActionResult editStudents(StudentCollege u)
        {
            string str = HttpContext.Session.GetString("Type");
            if(str!="lecturer")
            return RedirectToAction("Index","Home");
            db.StudentColleges.Update(u);
            db.SaveChanges();
            return RedirectToAction("showStudents", "Lecturer");
        }
        public IActionResult deleteStudents(string id)
        {
            string str = HttpContext.Session.GetString("Type");
            if(str!="lecturer")
            return RedirectToAction("Index","Home");
            StudentCollege e = db.StudentColleges.Find(id);
            return View(e);
        }
        [HttpPost]
        [ActionName("deleteStudents")] // mvc compiler
        public IActionResult deleteConfirmedStudents(string id) // c# compiler as alternate overload
        {
            string str = HttpContext.Session.GetString("Type");
            if(str!="lecturer")
            return RedirectToAction("Index","Home");
            StudentCollege e = db.StudentColleges.Find(id);
            db.StudentColleges.Remove(e);
            db.SaveChanges();
            return RedirectToAction("showStudents", "Lecturer");
        }

        // --------------------------------------------------------------------
        public IActionResult showGrades()
        {
            string str = HttpContext.Session.GetString("Type");
            if(str!="lecturer")
            return RedirectToAction("Index","Home");
            return View(db.GradeColleges);
        }

        [HttpPost]
        public IActionResult showGrades(IFormCollection f)
        {
            string str = HttpContext.Session.GetString("Type");
            if(str!="lecturer")
            return RedirectToAction("Index","Home");
            string keyword=f["keyword"].ToString();
            var u = db.GradeColleges.Where(x=>x.Email.Contains(keyword)).ToList();
            return View(u);
        }
        // [HttpGet]
        public IActionResult createGrades()
        {
            string str = HttpContext.Session.GetString("Type");
            if(str!="lecturer")
            return RedirectToAction("Index","Home");
            var result = db.StudentColleges.ToList();
            ViewBag.lt = result;
            return View();
        }
        [HttpPost]
        public IActionResult createGrades(GradeCollege obj)
        {
            string str = HttpContext.Session.GetString("Type");
            if(str!="lecturer")
            return RedirectToAction("Index","Home");
            db.GradeColleges.Add(obj);
            db.SaveChanges();
            return RedirectToAction("showGrades", "Lecturer");
        }
        public IActionResult editGrades(string id, string subject)
        {
            string str = HttpContext.Session.GetString("Type");
            if(str!="lecturer")
            return RedirectToAction("Index","Home");
            // UserCollege u = db.UserColleges.Find(id);
            GradeCollege u = db.GradeColleges.Where(x=>x.Email==id && x.Subject==subject).SingleOrDefault();
            return View(u);
        }
        [HttpPost]
        public IActionResult editGrades(GradeCollege u)
        {
            string str = HttpContext.Session.GetString("Type");
            if(str!="lecturer")
            return RedirectToAction("Index","Home");
            db.GradeColleges.Update(u);
            db.SaveChanges();
            return RedirectToAction("showGrades", "Lecturer");
        }
        
        public IActionResult deleteGrades(string id, string id_2)
        {
            string str = HttpContext.Session.GetString("Type");
            if(str!="lecturer")
            return RedirectToAction("Index","Home");
            // GradeCollege e = db.GradeColleges.Find(id);
            GradeCollege u = db.GradeColleges.Where(x=>x.Email==id && x.Subject==id_2).SingleOrDefault();
            return View(u);
        }
        [HttpPost]
        [ActionName("deleteGrades")] // mvc compiler
        public IActionResult deleteConfirmedGrades(string id, string id_2) // c# compiler as alternate overload
        {
            string str = HttpContext.Session.GetString("Type");
            if(str!="lecturer")
            return RedirectToAction("Index","Home");
            GradeCollege e = db.GradeColleges.Where(x=>x.Email==id && x.Subject==id_2).SingleOrDefault();
            if(e==null) RedirectToAction("success");
            db.GradeColleges.Remove(e);
            db.SaveChanges();
            return RedirectToAction("showGrades", "Lecturer");
        }
    }
}