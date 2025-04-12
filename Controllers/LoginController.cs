using Learning01ADN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Learning01ADN.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View("Login");
        }
        public string Login(UserModel userModel)
        {
            return "Result: Username: " + userModel.UserName + " PW " + userModel.Password;
        }
    }
}