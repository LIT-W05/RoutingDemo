using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


//localhost:123/account/index
//http://microsoft.com/how-to-attribute-routing
//localhost:123/aksjhd

namespace WebApplication26.Controllers
{
    [RoutePrefix("notstupid")]
    [Route("{action}")]
    public class StupidController : Controller
    {
        [Route("foo")]
        public void Index()
        {
            Response.Write("<h1>Not really that stupid!!</h1>");
        }

        public void Bar()
        {
            Response.Write("<h1>The bar page on stupid</h1>");
        }

        public void Baz()
        {
            Response.Write("<h1>Baz Page</h1>");
        }
    }
}