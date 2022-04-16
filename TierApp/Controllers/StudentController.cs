using BussinessLogicLayer;
using BussinessLogicLayer.BEnt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TierApp.Controllers
{
    public class StudentController : ApiController
    {
        [Route("api/Student/Name")]
        [HttpGet]
        public List<String>GetName()
        {
            return StudentService.GetNames();
        }

        [Route("api/Student/All")]
        [HttpGet]
        public List<StudentModel>Get()
        {
            var data = StudentService.Get();
            return data;
        }

        [Route("api/Student/Edit/{id}")]
        [HttpPost]
        public void Edit(StudentModel st,int id)
        {
            st.Id = id;
            StudentService.Edit(st);
        }

    }
}
