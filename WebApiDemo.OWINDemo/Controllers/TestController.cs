using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace WebApiDemo.OWINDemo.Controllers
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
