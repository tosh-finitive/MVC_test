using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_test.Controllers
{
    public class HomeController : Controller
    {
        bool flag = false;
        public ActionResult Index()
        {
            return View();
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
        public ActionResult Test()
        {
            ViewBag.flagvalue = flag;
            ViewBag.Message = "This is a test page";
            
            return View();

        }
        [HttpPost]
        public ActionResult Test(FormCollection frm)
        {
            flag = true;
            ViewBag.flagvalue = flag;
            ViewBag.First = frm["firstName"].ToString();
            ViewBag.Last = frm["lastName"].ToString();
            ViewBag.Responce = frm["Responce"].ToString();
            ViewBag.Ice = frm["iceRadio"].ToString();

            return View();

        }

        public ActionResult Login()
        {
            return View();
        }
            
    }
}