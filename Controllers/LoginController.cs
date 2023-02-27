using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CMS.Models;
using Microsoft.AspNetCore.Http;
using System.Web;  


namespace CMS.Controllers
{
    
    public class LoginController : Controller
    {
        private readonly ACE42023Context db;
        private readonly ISession session;

        public LoginController(ACE42023Context _db, IHttpContextAccessor httpContextAccessor)
        {
            db=_db;
            session = httpContextAccessor.HttpContext.Session;
        }
        [Route("login")]
        public IActionResult login()
        {
            return View();
        }
      
        [HttpPost]
        [Route("login")]
        public IActionResult login(UserCollege obj)
        {
            var result = (from i in db.UserColleges
                          where i.Email==obj.Email &&i.Password==obj.Password
                          select i).SingleOrDefault();
            if(result != null)
            {
                HttpContext.Session.SetString("Name", result.Name);
                HttpContext.Session.SetString("Email", result.Email);
                HttpContext.Session.SetString("Type", result.Type);
                HttpContext.Session.SetString("DashBoard", "1");
                return RedirectToAction("details", "Login");
            }
            else
            {
                return View();
            }
            
            
        }
        [Route("logout")]
        public IActionResult logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("login","Login");
        }
        public IActionResult register()
        {   
            string str = HttpContext.Session.GetString("Type");
            if(str!="admin")
            return RedirectToAction("Index","Home");

            return View();
        }
        [HttpPost]
        public IActionResult register(UserCollege obj)
        {   
            string str = HttpContext.Session.GetString("Type");
            if(str!="admin")
            return RedirectToAction("Index","Home");

            db.UserColleges.Add(obj);
            db.SaveChanges();
            return RedirectToAction("login");
        }
        public IActionResult ShowUsers()
        {   
            string str = HttpContext.Session.GetString("Type");
            if(str!="admin")
            return RedirectToAction("Index","Home");
            
            return View(db.UserColleges);
        }
        [HttpPost]
        public IActionResult ShowUsers(IFormCollection f)
        {   string str = HttpContext.Session.GetString("Type");
            if(str!="admin")
            return RedirectToAction("Index","Home");
            string keyword=f["keyword"].ToString();
            var u = db.UserColleges.Where(x=>x.Name.Contains(keyword)).ToList();
            return View(u);
        }
        [Route("det")]
        public IActionResult details(){
            HttpContext.Session.SetString("DashBoard", "1");
            string str = HttpContext.Session.GetString("Email");
            UserCollege u = db.UserColleges.Where(x=>x.Email==str).SingleOrDefault();
            return View(u);
        }

        [Route("Usr/{id}")]
        public IActionResult detailUser(string id)
        {
            UserCollege u = db.UserColleges.Where(x=>x.Email==id).SingleOrDefault();
            return View(u);
        }
        [Route("edt/{id}")]
        public IActionResult edit(string id)
        {
            // UserCollege u = db.UserColleges.Find(id);
            string str = HttpContext.Session.GetString("Type");
            if(str!="admin")
            return RedirectToAction("Index","Home");
            UserCollege u = db.UserColleges.Where(x=>x.Email==id).SingleOrDefault();
            return View(u);
        }
        [HttpPost]
        [Route("edt/{id}")]
        public IActionResult edit(UserCollege u)
        {
            string str = HttpContext.Session.GetString("Type");
            if(str!="admin")
            return RedirectToAction("Index","Home");
            db.UserColleges.Update(u);
            db.SaveChanges();
            return RedirectToAction("ShowUsers");
        }
    
        public IActionResult delete(string id)
        {
            string str = HttpContext.Session.GetString("Type");
            if(str!="admin")
            return RedirectToAction("Index","Home");
            if(id==null)
            return NotFound();
            UserCollege e = db.UserColleges.Find(id);
            if(e==null)
                return NotFound();
            return View(e);
        }
        [HttpPost]
        [ActionName("delete")] // mvc compiler
        public IActionResult deleteConfirmed(string id) // c# compiler as alternate overload
        {
            string str = HttpContext.Session.GetString("Type");
            if(str!="admin")
            return RedirectToAction("Index","Home");
            UserCollege e = db.UserColleges.Where(x=>x.Email==id).SingleOrDefault();
             if(e==null)
        return NotFound();
             db.UserColleges.Remove(e);
             db.SaveChanges();
            return RedirectToAction("ShowUsers");
        }


        // -------------------------------------------------
        public IActionResult success()
        {
            return View();
        }
    }
}