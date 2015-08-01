using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AngularJS_For_ASP.NET_Developers.Controllers
{
    public class LoginController : Controller
    {
        //
        // GET: /Login/

        public ActionResult LoginPage()
        {
            return View();
        }

        public ActionResult Login()
        {
            return null;
        }

    }
}
