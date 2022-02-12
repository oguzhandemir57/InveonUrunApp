using InveonUrunApp.BusinessOperators;
using InveonUrunApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InveonUrunApp.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public JsonResult LoginCheck(User user)
        {
            var result = new LoginOperator().UserCheck(user);
            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}