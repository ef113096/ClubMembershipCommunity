using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClubMembershipCommunity.Models;

namespace ClubMembershipCommunity.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index(int ID, string fullName, string chapterName)
        {
            ViewBag.UserFullName = fullName;
            ViewBag.ChapterName = chapterName;
            return View();
        }
    }
}