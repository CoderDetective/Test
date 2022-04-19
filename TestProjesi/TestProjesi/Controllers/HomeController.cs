using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestProjesi.Controllers
{
    public class HomeController : Controller
    {
        // GET: Homedsa
        public ActionResult Index()
        {
            string ss = "işlem tamamlandı";
            
            return View();
        }
    }
}