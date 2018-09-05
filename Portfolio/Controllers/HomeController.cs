using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Portfolio.Models;

namespace Portfolio.Controllers
{
    public class HomeController : Controller
    {
        // GET: Index
        public ActionResult Index()
        {
	        Data myData = new Data();
//	        Data.GetResumeList();
//	        ViewBag.Title = "Stephanie Spears - Resume";
            return View(myData);
        }

    }
}
