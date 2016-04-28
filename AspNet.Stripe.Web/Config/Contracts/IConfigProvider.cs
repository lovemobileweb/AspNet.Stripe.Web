namespace AspNet.Stripe.Web.Config.Contracts
{
    public interface IConfigProvider
    {
        T Get<T>() where T : class;
    }
}
