using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApI.Models;

namespace WebApI.Controllers
{
    public class DepartmentController : ApiController
    {
        [HttpGet]
        [Route("api/dept/all")]
         public HttpResponseMessage AllDept()
        {
            return Request.CreateResponse(HttpStatusCode.OK,"data");
        }
        [Route("api/dept/add")]
        [HttpPost]
        public HttpResponseMessage AllDept(Department d)
        {
            return Request.CreateResponse(HttpStatusCode.OK, "posted");
        }
    }
}
