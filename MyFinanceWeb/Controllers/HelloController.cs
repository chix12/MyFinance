using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFinanceWeb.Controllers
{
    public class HelloController : Controller
    {
        // GET: Hello
        public ActionResult Index()
        {
            return  View();
        }
        public ActionResult Welcom(String name,int numFois)
        {
            ViewBag.obj1 = name;
            ViewBag.obj2 = numFois;
            return View();

        }
    }
}