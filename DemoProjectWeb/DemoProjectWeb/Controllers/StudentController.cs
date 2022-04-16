using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DemoProjectWeb.Models; 

namespace DemoProjectWeb.Controllers
{
    public class StudentController : Controller
    {
        [HttpGet]
       public ActionResult Create()
        {
            return View(new Student());
        }
        [HttpPost]
        public ActionResult Create(Student s)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("List","Home");
            }
            return View(s);
        }
        [HttpPost]
        public ActionResult Submit(Student s)
        {
            return View(s);
        }

        public ActionResult List()
        {
            return View();
        }

    }
}