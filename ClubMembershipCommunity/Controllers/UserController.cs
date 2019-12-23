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
        public ActionResult Index(int ID, string fullName, string chapterName)
        {
            ViewBag.UserFullName = fullName;
            ViewBag.ChapterName = chapterName;
            return View();
        }

        public ActionResult Calendar()
        {
            return View();
        }
    }
}