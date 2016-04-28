using AspNet.Stripe.Web.Config.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNet.Stripe.Web.Config
{
    public class ConfigProvider : IConfigProvider
    {
        public T Get<T>() where T : class
        {
            return StripeConfiguration.Config as T;
        }
    }
}