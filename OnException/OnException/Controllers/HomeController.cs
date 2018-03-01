using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnException.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            throw new Exception("HomeController");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        [Route("error")]
        public ActionResult Error(string aspxerrorpath = "")
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }
    }

    public class BaseController : Controller
    {
        /// <summary>
        /// MVCエラー
        /// </summary>
        /// <param name="filterContext"></param>
        protected override void OnException(ExceptionContext filterContext)
        {
            Console.WriteLine("ControllerError");
        }
    }
}