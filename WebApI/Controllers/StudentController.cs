using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Script.Serialization;
using WebApI.Models;

namespace WebApI.Controllers
{
    public class StudentController : ApiController
    {
        public HttpResponseMessage Get()
        {
            List<student> persons = new List<student>();
            for (int i = 1; i <= 10; i++)
            {
                var p = new student()
                {
                    ID = ""+i,
                    Name = "Person" + i,
                };
                persons.Add(p);
            }
            var data = new JavaScriptSerializer().Serialize(persons);

            return Request.CreateResponse(HttpStatusCode.OK, data);
        }


    }
}
