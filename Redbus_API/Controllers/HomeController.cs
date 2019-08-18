using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;

namespace Redbus_API.Controllers
{
    public class HomeController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage GetAllBuses()
        {
            return Request.CreateResponse(System.Net.HttpStatusCode.OK, true);
        }
    }
}
