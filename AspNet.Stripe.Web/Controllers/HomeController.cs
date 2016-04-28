using System.Web.Mvc;

namespace AspNet.Stripe.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}