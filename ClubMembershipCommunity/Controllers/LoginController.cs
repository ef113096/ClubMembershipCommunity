using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


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

        public ActionResult ProcessLogin()
        {
            bool authenticated = false;
            return Content(authenticated.ToString(), "text/plain");
        }
    }
}