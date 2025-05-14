using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface ISubscription
    {
        string Name { get; }
        decimal MonthlyFee { get; }
        int MinSubscriptionPeriod { get; }
        List<string> Channels { get; }
        List<string> Features { get; }

        void PrintInfo();
    }
}
