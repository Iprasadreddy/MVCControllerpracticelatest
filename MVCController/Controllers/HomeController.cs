using System.Web.Mvc;

namespace MVCController.Controllers
{
    public class HomeController : Controller
    {
        //public string Greet()
        //{
        //    return "Welcome to mvc5";
        //}
        public ActionResult Index() 
        {
            return View();
        }
        public ActionResult Aboutus()
        {
            return View();
        }
        public ActionResult Contactus()
        {
            return View();
        }
        public ActionResult Blogs()
        {
            return View();
        }
    }
}