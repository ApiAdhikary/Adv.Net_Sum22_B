using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MidProject.Auth
{
    public class MemberAccess: AuthorizeAttribute  
    {
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            var value = httpContext.Session["logged_user"];
            if (value != null)
            {
                return true;
            }
            return false;

        }
    }
}