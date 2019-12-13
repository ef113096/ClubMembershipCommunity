using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClubMembershipCommunity.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index(string userFullName)
        {
            ViewBag.UserFullName = userFullName;
            return View();
        }
    }
}