using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiDemo.IISDemo.Controllers
{
    public class TestController : ApiController
    {
        [HttpPost]
        public List<string> List()
        {
            return new List<string>()
            {
                "minhua",
                "marcus"
            };
        }
    }
}
