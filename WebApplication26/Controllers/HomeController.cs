using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using shortid;

namespace WebApplication26.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.ShortId = ShortId.Generate(true, false);
            ViewBag.CurrentUrl = Request.Url.AbsoluteUri.Replace(Request.Url.PathAndQuery, "");
            return View();
        }

        public void Other(int id)
        {
            Response.Write($"<h1>The id passed in was: {id}</h1>");
        }

        [Route("foo/bar/baz")]
        public void Hello()
        {
            Response.Write("<h1>Hello page!!</h1>");
        }

        [Route("simchas/{simchaid}/contributions")]
        public void HelloFace(int simchaId)
        {
            Response.Write("<h1>Contributions page for id " + simchaId + "</h1>");
        }

        [Route("{title}")]
        public void Story(string title, string author)
        {
            Response.Write($"<h1>Story page for {title} - written by {author}</h1>");
        }
    }
}