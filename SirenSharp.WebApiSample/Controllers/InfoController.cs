using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SirenSharp.WebApiSample.Models;

namespace SirenSharp.WebApiSample.Controllers
{
    public class InfoController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var _info = new ServiceInfo();
            return this.Request.CreateResponse(HttpStatusCode.OK, _info);
        }
    }
}
