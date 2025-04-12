using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Learning01ADN.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }
        public string Welcome(string name, int ID=1)
        {
            return HttpUtility.HtmlEncode("Hello " + name + " Your ID is " + ID);
        }
        public ActionResult TestView()
        {
            return View();
        }
        public ActionResult ErrorMessage()
        {
            return View();
        }

        public string PrintMessage()
        {
            return "<h1>Welcome to my world!</h1><p>This is just a test paragraph</p>";
        }
    }
}