using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using Subscriptions;

namespace Creators
{
    public class ManagerCall : ISubscriptionCreator
    {
        public ISubscription CreateSubscription()
        {
            return new PremiumSubscription();
        }
    }
}

