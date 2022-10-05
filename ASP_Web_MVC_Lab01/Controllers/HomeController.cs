using ASP_Web_MVC.Models;
using System;
using System.Web.Mvc;

namespace ASP_Web_MVC.Controllers
{
    public class HomeController : Controller
    {
        public string Index(string hel)
        {
            int hour = DateTime.Now.Hour;
            string Greeting = ModelClass.ModelHello() + ", " + hel;
            return Greeting;
        }
    }
}