using System;
using MidProject.EF;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MidProject.Controllers
{
    public class MemberController : Controller
    {
        // GET: Member
       // [Authorize]
        public ActionResult Index()
        {
            
            MemberEntities2 db = new MemberEntities2 ();
              var members = db.MemberInfoes.ToList();
           
            return View(members);
           
        }
        public ActionResult Create()
        {
            
            MemberEntities2 db = new MemberEntities2();
            var member = db.MemberInfoes.ToList();
          
            return View(member); 
        }
    //    public ActionResult Create()
       // {
       //     MemberInfo s = new MemberInfo()
      //      {
        //        Id = "2", 
        //        Name = "Api",
         //       Dob = "16/10/1999" 
              

         //   };
      //  MemberEntities2 db = new MemberEntities2();
       //     db.MemberInfoes.Add(s);
      //      db.SaveChanges();

          //  return RedirectToAction("Index");
      //  }
        public ActionResult Edit(string id)
        {
            MemberEntities2 db = new MemberEntities2();
            var st = (from s in db.MemberInfoes where s.Id == id select s).SingleOrDefault();
            st.Name = "Edited Name";
            st.Dob = "16/10/1998";
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Delete(string id)
        {
            MemberEntities2 db = new MemberEntities2();
            var st = (from s in db.MemberInfoes where s.Id == id select s).SingleOrDefault();
            db.MemberInfoes.Remove(st);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}