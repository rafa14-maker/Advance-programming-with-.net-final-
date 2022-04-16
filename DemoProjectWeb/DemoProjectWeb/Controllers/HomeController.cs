using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DemoProjectWeb.Models;

namespace DemoProjectWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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
        public ActionResult Home()
        {
            Person p = new Person();
            p.Name = "Rafayet";
            p.Id = 345;
            p.Dob = DateTime.Now;


            return View(p);
        }

        public ActionResult List()
        {
            List<Person> persons = new List<Person>();
            for(int i=0;i<20;i++)
            {
                var p = new Person
                {
                    Id = i + 1,
                    Name = "Person" + (i+1),
                    Dob = DateTime.Now
                };
                persons.Add(p);
            }
            return View(persons);
        }
    }
}