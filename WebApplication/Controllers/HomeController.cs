using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLogic;
using BusinessObject;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(UserBO userBO)
        {
            if (ModelState.IsValid)
            {
                UserBL userBL = new UserBL();
                CustomBO customBO = userBL.AddUser(userBO);
                return RedirectToAction("Index");
            }
            return View(userBO);
        }
    }
}