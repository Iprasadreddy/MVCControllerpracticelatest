using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace MVCview_programming.Controllers
{
    public class HomController : Controller
    {
       
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Index1()
        {
            return View();
        }
        public ActionResult Index2()
        {
            return View();
        }
        public ActionResult Index3()
        {
            return View();
        }
        public ActionResult Index4()
        {
            return View();
        }
        public ActionResult Index5()
        {
            List<string> list = new List<string>() { "Admin", "Trainer", "HR", "Student" };
            SelectList items = new SelectList(list);
            ViewData["logins"] = items;
            return View();
        }
    }
}