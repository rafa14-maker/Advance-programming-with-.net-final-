using ApiStudentCRUD.Models.Database;
using ApiStudentCRUD.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Script.Serialization;

namespace ApiStudentCRUD.Controllers
{
    public class StudentController : ApiController
    {
        [Route("api/Student/Get")]
        [HttpGet]
        public HttpResponseMessage  Get()
        {
            List<StudentModel> li = new List<StudentModel>();

            Entities db = new Entities();

            var data = (from e in db.Students select e).ToList();

            foreach(var item in data)
            {
               StudentModel st = new StudentModel();
                st.Id = item.Id;
                st.Name = item.Name;
                st.Age = item.Age;
                st.Email = item.Email;
                li.Add(st);
            }
            var Datajava = new JavaScriptSerializer().Serialize(li);
            return Request.CreateResponse(HttpStatusCode.OK, Datajava);
        }
        [Route("api/Student/GetbyId/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            List<StudentModel> li = new List<StudentModel>();

            Entities db = new Entities();

            var data = (from e in db.Students select e).ToList();

            foreach (var item in data)
            {
                if (item.Id == id)
                {
                    StudentModel st = new StudentModel();
                    st.Id = item.Id;
                    st.Name = item.Name;
                    st.Age = item.Age;
                    st.Email = item.Email;
                    li.Add(st);
                }
            }
            var Datajava = new JavaScriptSerializer().Serialize(li);
            return Request.CreateResponse(HttpStatusCode.OK, Datajava);
        }


        [Route("api/Student/Create")]
        [HttpPost]
        public IHttpActionResult create(Student st)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Please enter valid student");
            }

            Entities db = new Entities();

            db.Students.Add(st);

            db.SaveChanges();

            return Ok();
        }

        [Route("api/Student/Delete/{id}")]
        [HttpPost]

        public IHttpActionResult Delete(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Please enter valid student");
            }

            Entities db = new Entities();

          var data = (from e in db.Students where(e.Id.Equals(id))select e).First();

            if( data != null )db.Students.Remove(data);

            db.SaveChanges();

            return Ok();
        }

        [Route("api/Student/Edit/{id}")]
        [HttpPost]
        public IHttpActionResult Edit(Student st,int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Please enter valid student");
            }

            Entities db = new Entities();

           var data = (from e in db.Students where(e.Id == id) select e).First();

            db.Entry(data).CurrentValues.SetValues(st);

            db.SaveChanges();

            return Ok();
        }

    }
}
