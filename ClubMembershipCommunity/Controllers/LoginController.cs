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

        public ActionResult ProcessLogin(string emailAddress, string password)
        {
            var data = new { result = "admin", name = "Earl Francis" };
            return Json(data, JsonRequestBehavior.AllowGet);
        }
    }
}