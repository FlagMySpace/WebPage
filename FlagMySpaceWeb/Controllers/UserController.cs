using FlagMySpaceWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Parse;
using System.Threading.Tasks;

namespace FlagMySpaceWeb.Controllers
{
    public class UserController : Controller
    {
        //
        // GET: /User/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Login(UserViewModel data)
        {
            ViewBag.SyncOrAsync = "Asynchronous";
            
            ParseObject gameScore = new ParseObject("GameScore");
            gameScore["score"] = 1337;
            gameScore["playerName"] = "Sean Plott";
            //await gameScore.SaveAsync();
            ViewBag.Message = data.Password + " " + data.Username;
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Register(UserViewModel data)
        {
            ViewBag.SyncOrAsync = "Asynchronous";

            ParseObject gameScore = new ParseObject("GameScore");
            gameScore["score"] = 1337;
            gameScore["playerName"] = "Sean Plott";
            //await gameScore.SaveAsync();
            ViewBag.Message = data.Password + " " + data.Username;
            return View();
        }
        /*public async Task<List<UserController>> GetGizmosAsync()
        {
            ParseObject gameScore = new ParseObject("GameScore");
            gameScore["score"] = 1337;
            gameScore["playerName"] = "Sean Plott";
            return await gameScore.SaveAsync();
        }*/
	}
}