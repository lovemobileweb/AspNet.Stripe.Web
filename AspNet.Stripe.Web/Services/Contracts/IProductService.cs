using AspNet.Stripe.Web.Models;

namespace AspNet.Stripe.Web.Services.Contracts
{
    public interface IProductService
    {
        ProductViewModel Get();
    }
}
