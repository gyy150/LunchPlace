using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public List<string> options = new List<string>();

        public HomeController()
        {
            options.Add("Malay");
            options.Add("KFC");
            options.Add("Maccs");
            options.Add("Golden Bakery");
            options.Add("IKEA");
            options.Add("Food Court");
        }

        public ActionResult DecideLunchPlace()
        {
            Random random = new Random();
            String Value = options.ElementAt(random.Next(0, options.Count-1));
            Value = "Vietnamnese";
            return Json(Value, JsonRequestBehavior.AllowGet);
        }
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
    }
}