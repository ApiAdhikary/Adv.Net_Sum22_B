using MidProject.Auth;
using MidProject.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MidProject.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [MemberAccess]
        public ActionResult Index()
        {
            var db = new MemberEntities2();
            var id =(Session["logged_user"].ToString());
            var st = (from s in db.MemberInfoes
                      where s.Id == id
                      select s).SingleOrDefault();
            return View(st);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}