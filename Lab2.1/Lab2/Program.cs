using Interfaces;
using Creators;
using System.Globalization;

class Program
{
    static void Main()
    {
        
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        ISubscriptionCreator[] creators = new ISubscriptionCreator[]
        {
            new WebSite(),
            new MobileApp(),
            new ManagerCall()
        };

        foreach (var creator in creators)
        {
            var subscription = creator.CreateSubscription();
            subscription.PrintInfo();
        }
    }
}
