using Learning01ADN.Models;
using Learning01ADN.Services.Business;
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
            //return "Result: Username: " + userModel.UserName + " PW " + userModel.Password;
            SecurityService securityService = new SecurityService();
            Boolean sucess = securityService.Authenticate(userModel);
            if (sucess)
            {
                return "Sucess";
            }
            else
            {
                return "Failed";
            }
        }
    }
}