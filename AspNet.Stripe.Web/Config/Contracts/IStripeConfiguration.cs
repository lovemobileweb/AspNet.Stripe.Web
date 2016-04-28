namespace AspNet.Stripe.Web.Config.Contracts
{
    public interface IStripeConfiguration
    {
        string StripePublishableKey { get; }
        string StripeSecretKey { get; }
    }
}
