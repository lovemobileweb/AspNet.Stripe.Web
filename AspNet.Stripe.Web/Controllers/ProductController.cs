using AspNet.Stripe.Web.Services.Contracts;
using System.Web.Mvc;

namespace AspNet.Stripe.Web.Controllers
{
    public class ProductController : Controller
    {
        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }

        public ActionResult Index()
        {
            return View(productService.Get());
        }

        protected readonly IProductService productService;
    }
}