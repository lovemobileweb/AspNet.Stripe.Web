using AspNet.Stripe.Web.Config.Contracts;
using AspNet.Stripe.Web.Models;
using AspNet.Stripe.Web.Services.Contracts;

namespace AspNet.Stripe.Web.Services
{
    public class ProductService: IProductService
    {
        public ProductService(IConfigProvider configProvider)
        {
            this.stripeConfiguration = configProvider.Get<IStripeConfiguration>();
        }

        public ProductViewModel Get()
        {
            var viewModel = new ProductViewModel();
            viewModel.StripePublishableKey = stripeConfiguration.StripePublishableKey;
            return viewModel;
        }

        protected readonly IStripeConfiguration stripeConfiguration;
    }
}