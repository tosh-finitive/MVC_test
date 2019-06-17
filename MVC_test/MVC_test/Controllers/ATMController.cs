using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_test.Models;

namespace MVC_test.Controllers
{
    public class ATMController : Controller
    {
        // GET: ATM
        public ActionResult Index()
        {
            ViewBag.Balance = 0;
            return View();
        }
        
        public ActionResult Withdraw()
        {
            ViewBag.Balance = 0;
            ViewBag.showBalance = false;

            withdrawCash cash = new withdrawCash();
            
            return View();
        }
        public ActionResult Deposit()
        {
            ViewBag.Balance = 0;
            ViewBag.showBalance = false;
            return View();
        }
        [HttpPost]
        public ActionResult Deposit(FormCollection frm)
        {
            ViewBag.showBalance = true;
            ViewBag.TakeOutRequest = frm["deposit"];
            return View();
        }
        [HttpPost]
        public ActionResult Withdraw(FormCollection frm)
        {
            ViewBag.Balance = 0;
            ViewBag.showBalance = true;
            ViewBag.TakeOutRequest = frm["withdraw"];

            return View();
        }
    }
}