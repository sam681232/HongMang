using HongMang.App_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HongMang.Controllers
{
    public class HomeController : Controller
    {
        readonly TempEntities Db = new TempEntities();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Index2()
        {
            var li = Db.F_Table.ToList();
            return View(li);
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