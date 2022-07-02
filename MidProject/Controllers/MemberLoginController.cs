using MidProject.EF;
using MidProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MidProject.Auth
{
    public class MemberLoginController : Controller
    {
        // GET: MemberLogin
        
            [HttpGet]
            public ActionResult Index()
            {
                return View();
            }
        
            [HttpPost]
            public ActionResult Index(MemberInfo model)
            {
                var db = new MemberEntities2();
                var st = (from s in db.MemberInfoes 
                          where s.Id.Equals(model.Id)
                          && s.Name.Equals(model.Name)
                          select s).SingleOrDefault();
                if (st != null)
                {
                    Session["logged_user"] = st.Id;
                    return RedirectToAction("Index", "Home");
                }
                TempData["msg"] = "User Does not exist";
                return View();

            }
            public ActionResult Logout()
            {
                Session.Remove("logged_user");
                return RedirectToAction("Index");
                //Session.RemoveAll();
            }
          
        
    }
}
