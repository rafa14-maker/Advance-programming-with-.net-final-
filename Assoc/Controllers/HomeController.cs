using Assoc.Auth;
using Assoc.Models.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Assoc.Controllers
{
    public class HomeController : Controller
    {
        [Authorize]
        public ActionResult Index()
        {
            //     UMS_Sp22_BEntities db = new UMS_Sp22_BEntities();
            //      var dept = (from d in db.Departments where d.Id == 1 select d).FirstOrDefault();
            ///     Department de = new Department();
            ///     de.Name = dept.Name;
            ///     de.Id = dept.Id;
            //     return View(dept);
            return View();
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]

        public ActionResult Login(User user)
        {
            UMS_Sp22_BEntities db = new UMS_Sp22_BEntities();
            var data = (from e in db.Users
                        where e.password.Equals(user.password) &&
                        e.Username.Equals(user.Username)
                        select e).FirstOrDefault();
            if(data != null)
            {
                FormsAuthentication.SetAuthCookie("data.Username", false);
                Session["Role"] = data.Role;
                return RedirectToAction("Index");
            }
            TempData["msg"] = "Invalid Crdentials";
            return RedirectToAction("Login");
        }

        [AdminAccess]

        public ActionResult UserList()
        {
            UMS_Sp22_BEntities db = new UMS_Sp22_BEntities();
            return View(db.Users.ToList());
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}