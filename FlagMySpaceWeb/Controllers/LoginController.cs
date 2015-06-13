using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FlagMySpaceWeb.Controllers
{
    public class LoginController : Controller
    {
        // 
        // GET: /Login/ 
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string x)
        {
            ViewBag.Message = "wtf";
            return View();
        }
	}
}