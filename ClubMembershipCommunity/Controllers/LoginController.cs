using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClubMembershipCommunity.Models;

namespace ClubMembershipCommunity.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        [Route("Login")]
        public ActionResult UserLogin()
        {
            return View();
        }

        public ActionResult ProcessLogin(string emailAddress, string password)
        {
            UserInfo userInfo = new UserInfo();
            userInfo.ID = 28;
            userInfo.LoginResults = "admin";
            userInfo.FullName = "Earl Francis";
            userInfo.ChapterName = "Houston Hearthstone AWS Chapter";

            return Json(userInfo, JsonRequestBehavior.AllowGet);
        }
    }
}